using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EcoApp
{
    // Класс формы Form1
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ops = new List<Operation>();
            TypeOperationCombobox.DataSource = Enum.GetValues(typeof(OperationType));
            SetNonState();
        }

        List<Operation> ops { get; set; } 
        OperationType? OperationCurrentType { get; set; } 
        decimal OperationCurrentValue { get; set; }
        string OperationCurrentName { get; set; }
        TreeNode SelectedNode { get; set; }
                
        private void AddLevelButton_Click(object sender, EventArgs e)
        {
            if (SelectedNode == null) return;
        }

        //Set - Установить
        //Non - Не/Отсутствие
        //State - Состояние
        public void SetNonState() 
        {
            // устанавливаем флаги доступа
            AddLevelButton.Enabled = false;
            EditSelectedButton.Enabled = false;
            DeleteSelectedButton.Enabled = false;
            TypeOperationCombobox.Enabled = false;
            NameOperationBox.Enabled = false;
            ValueOperationBox.Enabled = false;
            SaveButton.Enabled = false;
            CancelButton.Enabled = false;

            // сбрасываем свойства
            OperationCurrentType = null;
            OperationCurrentName = null;
            OperationCurrentValue = 0;
        }
        
        private void CancelButton_Click(object sender, EventArgs e)
        {
            SetNonState();
        }
        
        private void NameOperationBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Operation newOp = new Operation()
            {
                Name = OperationCurrentName,
                Value = OperationCurrentValue,
                Type = OperationCurrentType
            };
            ops.Add(newOp);

            SelectedNode.Nodes.Add(new TreeNode(newOp.Name + " | " + newOp.Type + " | " + newOp.Value));
            SelectedNode.Expand();
            SetNonState();
        }
        
        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {

        }
        
        private void EditSelectedButton_Click(object sender, EventArgs e)
        {
            TypeOperationCombobox.SelectedValue = OperationCurrentType;
            NameOperationBox.Text = OperationCurrentName;
            ValueOperationBox.Value = OperationCurrentValue;
        }
        
        private void TypeOperationCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            OperationPropertiesValidation();
        }
        
        private void OperationPropertiesValidation()
        {
            if (String.IsNullOrEmpty(OperationCurrentName) && OperationCurrentType.HasValue)
            {
                SaveButton.Enabled = true;
            }
            SaveButton.Enabled = false;
        }
        
        private void ValueOperationBox_ValueChanged(object sender, EventArgs e)
        {
            OperationCurrentValue = ValueOperationBox.Value;
            OperationPropertiesValidation();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode == null) return;
            SelectedNode = treeView1.SelectedNode;
            OperationCurrentType = (OperationType)TypeOperationCombobox.SelectedValue;
            OperationCurrentName = NameOperationBox.Text;
            OperationCurrentValue = ValueOperationBox.Value;
            OperationPropertiesValidation();
        }

    }// public partial class Form1 : Form
} // namespace EcoApp
