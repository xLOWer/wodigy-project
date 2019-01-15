namespace EcoApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Корень");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ValueOperationBox = new System.Windows.Forms.NumericUpDown();
            this.NameOperationBox = new System.Windows.Forms.TextBox();
            this.TypeOperationCombobox = new System.Windows.Forms.ComboBox();
            this.EditSelectedButton = new System.Windows.Forms.Button();
            this.DeleteSelectedButton = new System.Windows.Forms.Button();
            this.AddLevelButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SaveXml = new System.Windows.Forms.Button();
            this.LoadXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValueOperationBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.LoadXml);
            this.splitContainer1.Panel1.Controls.Add(this.SaveXml);
            this.splitContainer1.Panel1.Controls.Add(this.CancelButton);
            this.splitContainer1.Panel1.Controls.Add(this.SaveButton);
            this.splitContainer1.Panel1.Controls.Add(this.ValueOperationBox);
            this.splitContainer1.Panel1.Controls.Add(this.NameOperationBox);
            this.splitContainer1.Panel1.Controls.Add(this.TypeOperationCombobox);
            this.splitContainer1.Panel1.Controls.Add(this.EditSelectedButton);
            this.splitContainer1.Panel1.Controls.Add(this.DeleteSelectedButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddLevelButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CancelButton.Location = new System.Drawing.Point(0, 153);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(145, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveButton.Location = new System.Drawing.Point(0, 130);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(145, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ValueOperationBox
            // 
            this.ValueOperationBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ValueOperationBox.Location = new System.Drawing.Point(0, 110);
            this.ValueOperationBox.Name = "ValueOperationBox";
            this.ValueOperationBox.Size = new System.Drawing.Size(145, 20);
            this.ValueOperationBox.TabIndex = 5;
            this.ValueOperationBox.ValueChanged += new System.EventHandler(this.ValueOperationBox_ValueChanged);
            // 
            // NameOperationBox
            // 
            this.NameOperationBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameOperationBox.Location = new System.Drawing.Point(0, 90);
            this.NameOperationBox.Name = "NameOperationBox";
            this.NameOperationBox.Size = new System.Drawing.Size(145, 20);
            this.NameOperationBox.TabIndex = 4;
            this.NameOperationBox.TextChanged += new System.EventHandler(this.NameOperationBox_TextChanged);
            // 
            // TypeOperationCombobox
            // 
            this.TypeOperationCombobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TypeOperationCombobox.FormattingEnabled = true;
            this.TypeOperationCombobox.Location = new System.Drawing.Point(0, 69);
            this.TypeOperationCombobox.Name = "TypeOperationCombobox";
            this.TypeOperationCombobox.Size = new System.Drawing.Size(145, 21);
            this.TypeOperationCombobox.TabIndex = 3;
            this.TypeOperationCombobox.SelectedValueChanged += new System.EventHandler(this.TypeOperationCombobox_SelectedValueChanged);
            // 
            // EditSelectedButton
            // 
            this.EditSelectedButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditSelectedButton.Location = new System.Drawing.Point(0, 46);
            this.EditSelectedButton.Name = "EditSelectedButton";
            this.EditSelectedButton.Size = new System.Drawing.Size(145, 23);
            this.EditSelectedButton.TabIndex = 2;
            this.EditSelectedButton.Text = "Изменить";
            this.EditSelectedButton.UseVisualStyleBackColor = true;
            this.EditSelectedButton.Click += new System.EventHandler(this.EditSelectedButton_Click);
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteSelectedButton.Location = new System.Drawing.Point(0, 23);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(145, 23);
            this.DeleteSelectedButton.TabIndex = 1;
            this.DeleteSelectedButton.Text = "Удалить";
            this.DeleteSelectedButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // AddLevelButton
            // 
            this.AddLevelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddLevelButton.Location = new System.Drawing.Point(0, 0);
            this.AddLevelButton.Name = "AddLevelButton";
            this.AddLevelButton.Size = new System.Drawing.Size(145, 23);
            this.AddLevelButton.TabIndex = 0;
            this.AddLevelButton.Text = "Добавить";
            this.AddLevelButton.UseVisualStyleBackColor = true;
            this.AddLevelButton.Click += new System.EventHandler(this.AddLevelButton_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode3.Name = "Root";
            treeNode3.Text = "Корень";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(651, 450);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // SaveXml
            // 
            this.SaveXml.Location = new System.Drawing.Point(12, 415);
            this.SaveXml.Name = "SaveXml";
            this.SaveXml.Size = new System.Drawing.Size(114, 23);
            this.SaveXml.TabIndex = 8;
            this.SaveXml.Text = "Сохранить(xml)";
            this.SaveXml.UseVisualStyleBackColor = true;
            this.SaveXml.Click += new System.EventHandler(this.SaveXml_Click);
            // 
            // LoadXml
            // 
            this.LoadXml.Location = new System.Drawing.Point(12, 386);
            this.LoadXml.Name = "LoadXml";
            this.LoadXml.Size = new System.Drawing.Size(114, 23);
            this.LoadXml.TabIndex = 9;
            this.LoadXml.Text = "Загрухить(xml)";
            this.LoadXml.UseVisualStyleBackColor = true;
            this.LoadXml.Click += new System.EventHandler(this.LoadXml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Экономическое приложение";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ValueOperationBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.NumericUpDown ValueOperationBox;
        private System.Windows.Forms.TextBox NameOperationBox;
        private System.Windows.Forms.ComboBox TypeOperationCombobox;
        private System.Windows.Forms.Button EditSelectedButton;
        private System.Windows.Forms.Button DeleteSelectedButton;
        private System.Windows.Forms.Button AddLevelButton;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button LoadXml;
        private System.Windows.Forms.Button SaveXml;
    }
}

