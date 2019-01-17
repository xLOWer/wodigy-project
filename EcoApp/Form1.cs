using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EcoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ops = new List<Operation>();
            TypeOperationCombobox.DataSource = Enum.GetValues(typeof(OperationType));
            NonState();
        }

        List<Operation> ops { get; set; }
                
        private void AddLevelButton_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) return;
            EditingState();
        }

        public void NonState() 
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

        public void EditingState()
        {

        }

        public void ChangingState()
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            NonState();
            //123
        }
        
        private void NameOperationBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Operation newOp = new Operation()
            {
                Name = NameOperationBox.Text,
                Value = ValueOperationBox.Value,
                Type = (OperationType)TypeOperationCombobox.SelectedValue
            };
            ops.Add(newOp);

            treeView1.SelectedNode.Nodes.Add(new TreeNode(newOp.Name + " | " + newOp.Type + " | " + newOp.Value));
            treeView1.SelectedNode.Expand();
            NonState();
        }
        
        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {

        }
        
        private void EditSelectedButton_Click(object sender, EventArgs e)
        {

        }
        
        private void TypeOperationCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            OperationPropertiesValidation();
        }
        
        private void OperationPropertiesValidation()
        {
            SaveButton.Enabled = false;

            if ( ! String.IsNullOrEmpty(NameOperationBox.Text) 
                && TypeOperationCombobox.SelectedValue != null)
            {
                SaveButton.Enabled = true;
            }
        }
        
        private void ValueOperationBox_ValueChanged(object sender, EventArgs e)
        {
            OperationPropertiesValidation();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode == null) return;

            OperationPropertiesValidation();
        }

    }// public partial class Form1 : Form
} // namespace EcoApp
