using EcoApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EcoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Operation op = new Operation { Name = "Корень" };
            op.Parent = null;
            OperationsList.Add(op);
            TreeView1.Nodes.Add(op.Id.ToString(), $@"{op.Name}");
            SelectedMode();
            TypeOperationComboBox1.DataSource = Enum.GetValues(typeof(OperationType));
            TreeView1.CheckBoxes = true;
        }

        public bool IsEditMode { get; set; } = false;
        public List<Operation> OperationsList { get; set; } = new List<Operation>();
        public TreeNode SelectedNode => TreeView1.SelectedNode;

        private void SelectedMode()
        {
            if (SelectedNode == null)
            {
                AddLevelButton1.Enabled = false;
                DeleteSelectedButton1.Enabled = false;
                EditSelectedButton1.Enabled = false;

                TypeOperationComboBox1.Visible = false;
                NameOperationBox1.Visible = false;
                ValueOperationBox1.Visible = false;
                CancelOperationButton1.Visible = false;
                CanSave(false);
                return;
            }
            AddLevelButton1.Enabled = true;
            DeleteSelectedButton1.Enabled = true;
            EditSelectedButton1.Enabled = true;

            TypeOperationComboBox1.Visible = false;
            NameOperationBox1.Visible = false;
            ValueOperationBox1.Visible = false;
            CancelOperationButton1.Visible = false;
            CanSave(false);
        }
        private void EditMode()
        {
            AddLevelButton1.Enabled = false;
            DeleteSelectedButton1.Enabled = false;
            EditSelectedButton1.Enabled = false;

            TypeOperationComboBox1.Visible = true;
            NameOperationBox1.Visible = true;
            ValueOperationBox1.Visible = true;
            CancelOperationButton1.Visible = true;
        }
        private void AddMode()
        {
            AddLevelButton1.Enabled = false;
            DeleteSelectedButton1.Enabled = false;
            EditSelectedButton1.Enabled = false;

            TypeOperationComboBox1.Visible = true;
            NameOperationBox1.Visible = true;
            ValueOperationBox1.Visible = true;
            CancelOperationButton1.Visible = true;
        }
        private void CanSave(bool val = true)
        {
            SaveOperationButton1.Visible = val;
        }


        private void AddLevelButton_Click(object sender, EventArgs e)
        {
            AddMode();
        }

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {
            if (SelectedNode.Text == "Корень")
            {
                MessageBox.Show("Нельзя удалить корневую ноду", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Точно хотите удалить?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                OperationsList.RemoveAll(f => f.Id == Guid.Parse(SelectedNode.Name));
                //TreeView1.Nodes.RemoveByKey(SelectedNode.Name);
                TreeView1.Refresh();
                TreeView1.Nodes.RemoveAt(SelectedNode.Index);
            }
            SelectedMode();
        }

        private void EditSelectedButton_Click(object sender, EventArgs e)
        {
            EditMode();
            Operation op = OperationsList.FirstOrDefault(f => f.Id == Guid.Parse(SelectedNode.Name));
            ValueOperationBox1.Value = Decimal.Parse(op.Value.ToString());
            TypeOperationComboBox1.SelectedIndex = (int)op.Type;
            NameOperationBox1.Text = op.Name;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Operation op = new Operation();
            op.Value = Double.Parse(ValueOperationBox1.Value.ToString());
            op.Type = (OperationType)TypeOperationComboBox1.SelectedIndex;
            op.Name = NameOperationBox1.Text;
            SelectedNode.Nodes.Add(op.Id.ToString(), $@"{op.Name} | {op.Type} | {op.Value} руб.");
            SelectedMode();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            SelectedMode();
            ValueOperationBox1.Value = 0;
            TypeOperationComboBox1.SelectedIndex = 1;
            NameOperationBox1.Text = "";
        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //SelectedNode = e.Node;
            this.Text = SelectedNode.Name;
            SelectedMode();
        }

        private void NameOperationBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(NameOperationBox1.Text) || !String.IsNullOrWhiteSpace(NameOperationBox1.Text))
                CanSave();
            else
                CanSave(false);

        }
    }
}
