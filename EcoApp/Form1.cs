using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EcoApp
{
    // Класс формы Form1
    public partial class Form1 : Form
    {
        /*
         * В самом верху класса идёт конструктор(ы)
         * Далее следуют свойства/поля/переменные в порядке:
         *      1) private
         *      2) protected
         *      3) public
         * Далее идут функции/методы/выражения в таком-же как свойства порядке
         * 
         * В файле HelpClass есть полезные подсказки
         */

        // Конструктор формы Form1
        public Form1()
        {
            InitializeComponent(); // создаём кнопочки ИЛИ инициализируем компоненты формы
            ops = new List<Operation>(); // инициализируем массив операций
            TypeOperationCombobox.DataSource = Enum.GetValues(typeof(OperationType)); // задаём массив типов операций в ComboBox
            StartView(); // выполняем функцию, блокирующую управление при старте
        }

        List<Operation> ops { get; set; } // свойство, массив операций
        OperationType? OperationCurrentType { get; set; } // тут хранится выбранный тип операции
        decimal OperationCurrentValue { get; set; } // тут хранится выбранное значение операции
        string OperationCurrentName { get; set; } // тут хранится выбранное имя операции
        TreeNode SelectedNode { get; set; } // тут хранится выбранное имя операции


        // Функция отвечающая за клик по кнопке "Добавить"
        private void AddLevelButton_Click(object sender, EventArgs e)
        {
            if (SelectedNode == null) return; // проверим, а не null ли наша выбранная нода(в см. выбрали ли мы что-то)

            TypeOperationCombobox.Enabled = true;
            NameOperationBox.Enabled = true;
            ValueOperationBox.Enabled = true;
            CancelButton.Enabled = true;

        }

        // Функция отвечающая за блокировку элементов управления при старте
        public void StartView()
        {
            AddLevelButton.Enabled = false;
            EditSelectedButton.Enabled = false;
            DeleteSelectedButton.Enabled = false;
            TypeOperationCombobox.Enabled = false;
            NameOperationBox.Enabled = false;
            ValueOperationBox.Enabled = false;
            SaveButton.Enabled = false;
            CancelButton.Enabled = false;
        }

        // Функция отвечающая за клик по кнопке "Отмена"
        private void CancelButton_Click(object sender, EventArgs e)
        {
            StartView(); // задаём изначальный вид
            OperationCurrentType = null; // обнуляем свойства
            OperationCurrentName = null;
            OperationCurrentValue = 0;
        }

        // Функция отвечающая за изменение текста в текстовом поле NameOperation
        private void NameOperationBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Функция отвечающая за клик по кнопке "Сохранить"
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Operation newOp = new Operation()
            {
                Name = OperationCurrentName,
                Value = OperationCurrentValue,
                Type = OperationCurrentType
            };
            ops.Add(newOp);

            SelectedNode.Nodes.Add(new TreeNode(newOp.Name+" | "+ newOp.Type + " | " + newOp.Value));
            SelectedNode.Expand();
            OperationCurrentType = null; // обнуляем свойства
            OperationCurrentName = null;
            OperationCurrentValue = 0;
            StartView(); // задаём изначальный вид
        }

        // Функция отвечающая за клик по кнопке "Удалить"
        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {

        }

        // Функция отвечающая за клик по кнопке "Редактировать"
        private void EditSelectedButton_Click(object sender, EventArgs e)
        {
            TypeOperationCombobox.SelectedValue = OperationCurrentType;
            NameOperationBox.Text = OperationCurrentName; // задаём свойства
            ValueOperationBox.Value = OperationCurrentValue;
        }

        // Функция срабатывающая в момент изменения текста в TypeBox
        private void TypeOperationCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            OperationPropertiesValidation();
        }
        
        // Функция проверяет всё ли впорядке в полях ввода и возвращает true если всё ок
        private void OperationPropertiesValidation()
        {
            // "классический" подход
            if (String.IsNullOrEmpty(OperationCurrentName) // проверяем, выбрано ли чтото в TypeBox
                && OperationCurrentType is OperationType) // заполнено ли поле NameBox
            {
                SaveButton.Enabled = true;
            }
            SaveButton.Enabled = false;
        }

        // Функция срабатывающая в момент изменения текста в ValueBox
        private void ValueOperationBox_ValueChanged(object sender, EventArgs e)
        {
            OperationCurrentValue = ValueOperationBox.Value;
            OperationPropertiesValidation();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode == null) return;
            SelectedNode = treeView1.SelectedNode;
            AddLevelButton.Enabled = true;
            DeleteSelectedButton.Enabled = true;
            EditSelectedButton.Enabled = true;
            OperationCurrentType = (OperationType)TypeOperationCombobox.SelectedValue;
            OperationCurrentName = NameOperationBox.Text; // задаём свойства
            OperationCurrentValue = ValueOperationBox.Value;
            OperationPropertiesValidation();
        }
    }// public partial class Form1 : Form
} // namespace EcoApp
