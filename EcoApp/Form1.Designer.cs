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
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.AddLevelButton1 = new System.Windows.Forms.Button();
            this.DeleteSelectedButton1 = new System.Windows.Forms.Button();
            this.EditSelectedButton1 = new System.Windows.Forms.Button();
            this.SaveOperationButton1 = new System.Windows.Forms.Button();
            this.NameOperationBox1 = new System.Windows.Forms.TextBox();
            this.ValueOperationBox1 = new System.Windows.Forms.NumericUpDown();
            this.CancelOperationButton1 = new System.Windows.Forms.Button();
            this.TypeOperationComboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ValueOperationBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeView1
            // 
            this.TreeView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.TreeView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TreeView1.Location = new System.Drawing.Point(186, 0);
            this.TreeView1.Name = "TreeView1";
            this.TreeView1.Size = new System.Drawing.Size(768, 505);
            this.TreeView1.TabIndex = 0;
            this.TreeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // AddLevelButton1
            // 
            this.AddLevelButton1.Location = new System.Drawing.Point(12, 12);
            this.AddLevelButton1.Name = "AddLevelButton1";
            this.AddLevelButton1.Size = new System.Drawing.Size(168, 26);
            this.AddLevelButton1.TabIndex = 1;
            this.AddLevelButton1.Text = "Добавить подуровень";
            this.AddLevelButton1.UseVisualStyleBackColor = true;
            this.AddLevelButton1.Click += new System.EventHandler(this.AddLevelButton_Click);
            // 
            // DeleteSelectedButton1
            // 
            this.DeleteSelectedButton1.Location = new System.Drawing.Point(12, 41);
            this.DeleteSelectedButton1.Name = "DeleteSelectedButton1";
            this.DeleteSelectedButton1.Size = new System.Drawing.Size(168, 26);
            this.DeleteSelectedButton1.TabIndex = 2;
            this.DeleteSelectedButton1.Text = "Удалить выбранный";
            this.DeleteSelectedButton1.UseVisualStyleBackColor = true;
            this.DeleteSelectedButton1.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // EditSelectedButton1
            // 
            this.EditSelectedButton1.Location = new System.Drawing.Point(12, 70);
            this.EditSelectedButton1.Name = "EditSelectedButton1";
            this.EditSelectedButton1.Size = new System.Drawing.Size(168, 26);
            this.EditSelectedButton1.TabIndex = 3;
            this.EditSelectedButton1.Text = "Изменить выбранный";
            this.EditSelectedButton1.UseVisualStyleBackColor = true;
            this.EditSelectedButton1.Click += new System.EventHandler(this.EditSelectedButton_Click);
            // 
            // SaveOperationButton1
            // 
            this.SaveOperationButton1.Location = new System.Drawing.Point(13, 291);
            this.SaveOperationButton1.Name = "SaveOperationButton1";
            this.SaveOperationButton1.Size = new System.Drawing.Size(168, 26);
            this.SaveOperationButton1.TabIndex = 4;
            this.SaveOperationButton1.Text = "Сохранить";
            this.SaveOperationButton1.UseVisualStyleBackColor = true;
            this.SaveOperationButton1.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameOperationBox1
            // 
            this.NameOperationBox1.Location = new System.Drawing.Point(12, 235);
            this.NameOperationBox1.Name = "NameOperationBox1";
            this.NameOperationBox1.Size = new System.Drawing.Size(168, 22);
            this.NameOperationBox1.TabIndex = 7;
            this.NameOperationBox1.TextChanged += new System.EventHandler(this.NameOperationBox1_TextChanged);
            // 
            // ValueOperationBox1
            // 
            this.ValueOperationBox1.Location = new System.Drawing.Point(13, 263);
            this.ValueOperationBox1.Name = "ValueOperationBox1";
            this.ValueOperationBox1.Size = new System.Drawing.Size(168, 22);
            this.ValueOperationBox1.TabIndex = 8;
            // 
            // CancelOperationButton1
            // 
            this.CancelOperationButton1.Location = new System.Drawing.Point(13, 323);
            this.CancelOperationButton1.Name = "CancelOperationButton1";
            this.CancelOperationButton1.Size = new System.Drawing.Size(168, 26);
            this.CancelOperationButton1.TabIndex = 9;
            this.CancelOperationButton1.Text = "Отменить";
            this.CancelOperationButton1.UseVisualStyleBackColor = true;
            this.CancelOperationButton1.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TypeOperationComboBox1
            // 
            this.TypeOperationComboBox1.FormattingEnabled = true;
            this.TypeOperationComboBox1.Location = new System.Drawing.Point(13, 205);
            this.TypeOperationComboBox1.Name = "TypeOperationComboBox1";
            this.TypeOperationComboBox1.Size = new System.Drawing.Size(167, 24);
            this.TypeOperationComboBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 505);
            this.Controls.Add(this.TypeOperationComboBox1);
            this.Controls.Add(this.CancelOperationButton1);
            this.Controls.Add(this.ValueOperationBox1);
            this.Controls.Add(this.NameOperationBox1);
            this.Controls.Add(this.SaveOperationButton1);
            this.Controls.Add(this.EditSelectedButton1);
            this.Controls.Add(this.DeleteSelectedButton1);
            this.Controls.Add(this.AddLevelButton1);
            this.Controls.Add(this.TreeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ValueOperationBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeView1;
        private System.Windows.Forms.Button AddLevelButton1;
        private System.Windows.Forms.Button DeleteSelectedButton1;
        private System.Windows.Forms.Button EditSelectedButton1;
        private System.Windows.Forms.Button SaveOperationButton1;
        private System.Windows.Forms.TextBox NameOperationBox1;
        private System.Windows.Forms.NumericUpDown ValueOperationBox1;
        private System.Windows.Forms.Button CancelOperationButton1;
        private System.Windows.Forms.ComboBox TypeOperationComboBox1;
    }
}

