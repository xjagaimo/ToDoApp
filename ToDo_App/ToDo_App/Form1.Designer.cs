namespace ToDo_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.refreshButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.testCheckBox = new System.Windows.Forms.CheckedListBox();
            this.WhatIsChecked = new System.Windows.Forms.Button();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.NewDescBox = new System.Windows.Forms.TextBox();
            this.LabelAct = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(273, 449);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(100, 28);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "hey :)";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(784, 112);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(236, 30);
            this.titleTextBox.TabIndex = 2;
            this.titleTextBox.Text = "Nama Aktivitas";
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(899, 447);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(100, 28);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "button1";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(548, 449);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 28);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // testCheckBox
            // 
            this.testCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testCheckBox.FormattingEnabled = true;
            this.testCheckBox.Location = new System.Drawing.Point(29, 104);
            this.testCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.testCheckBox.Name = "testCheckBox";
            this.testCheckBox.Size = new System.Drawing.Size(212, 329);
            this.testCheckBox.TabIndex = 5;
            this.testCheckBox.Click += new System.EventHandler(this.testCheckBox_Click);
            this.testCheckBox.SelectedIndexChanged += new System.EventHandler(this.testCheckBox_SelectedIndexChanged);
            // 
            // WhatIsChecked
            // 
            this.WhatIsChecked.Location = new System.Drawing.Point(396, 452);
            this.WhatIsChecked.Name = "WhatIsChecked";
            this.WhatIsChecked.Size = new System.Drawing.Size(130, 23);
            this.WhatIsChecked.TabIndex = 6;
            this.WhatIsChecked.Text = "WhatIsChecked";
            this.WhatIsChecked.UseVisualStyleBackColor = true;
            this.WhatIsChecked.Click += new System.EventHandler(this.WhatIsChecked_Click);
            // 
            // DescBox
            // 
            this.DescBox.Location = new System.Drawing.Point(273, 104);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(271, 203);
            this.DescBox.TabIndex = 7;
            this.DescBox.TextChanged += new System.EventHandler(this.DescBox_TextChanged);
            // 
            // NewDescBox
            // 
            this.NewDescBox.Location = new System.Drawing.Point(784, 161);
            this.NewDescBox.Multiline = true;
            this.NewDescBox.Name = "NewDescBox";
            this.NewDescBox.Size = new System.Drawing.Size(236, 258);
            this.NewDescBox.TabIndex = 8;
            // 
            // LabelAct
            // 
            this.LabelAct.AutoSize = true;
            this.LabelAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAct.Location = new System.Drawing.Point(25, 66);
            this.LabelAct.Name = "LabelAct";
            this.LabelAct.Size = new System.Drawing.Size(86, 22);
            this.LabelAct.TabIndex = 9;
            this.LabelAct.Text = "Activities:";
            this.LabelAct.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(302, 335);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LabelAct);
            this.Controls.Add(this.NewDescBox);
            this.Controls.Add(this.DescBox);
            this.Controls.Add(this.WhatIsChecked);
            this.Controls.Add(this.testCheckBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.refreshButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.CheckedListBox testCheckBox;
        private System.Windows.Forms.Button WhatIsChecked;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.TextBox NewDescBox;
        private System.Windows.Forms.Label LabelAct;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

