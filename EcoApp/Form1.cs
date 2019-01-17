using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

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
            xmlSer = new XmlSerializer(ops.GetType());
        }

        XmlSerializer xmlSer;
        List<Operation> ops;

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
            AddLevelButton.Enabled = true;
            EditSelectedButton.Enabled = true;
        }

        public void ChangingState()
        {
            AddLevelButton.Enabled = false;
            EditSelectedButton.Enabled = false;
            DeleteSelectedButton.Enabled = false;

            TypeOperationCombobox.Enabled = true;
            NameOperationBox.Enabled = true;
            ValueOperationBox.Enabled = true;

            SaveButton.Enabled = false;
            CancelButton.Enabled = true;

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

        private void AddLevelButton_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) return;
            ChangingState();
        }

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {

        }
        
        private void EditSelectedButton_Click(object sender, EventArgs e)
        {
            ChangingState();
        }
        
        private void TypeOperationCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            OperationPropertiesValidation();
        }
        
        private void OperationPropertiesValidation()
        {
            SaveButton.Enabled = false;

            if ( ! String.IsNullOrEmpty(NameOperationBox.Text) 
                /*&& (OperationType)TypeOperationCombobox.SelectedValue */)
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

            EditingState();
        }

        private void SaveXml_Click(object sender, EventArgs e)
        {
            var FileStream = new FileStream("ops.xml", FileMode.Append | FileMode.Append);

            using (var stream = XmlWriter.Create(FileStream) )
            {
                xmlSer.Serialize(stream, ops[0]);
            }
        }

        private void LoadXml_Click(object sender, EventArgs e)
        {
            using (
                    var stream = XmlReader.Create(
                        new FileStream("ops.xml", FileMode.Open)
                    )
                )
            {
                ops.Add((Operation)xmlSer.Deserialize(stream));
            }

            treeView1.Nodes["root"].Nodes.Add(ops[0].Name + " | " + ops[0].Type + " | " + ops[0].Value);
        }
    }// public partial class Form1 : Form
} // namespace EcoApp
