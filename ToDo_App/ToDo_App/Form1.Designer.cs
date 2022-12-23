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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.testCheckBox = new System.Windows.Forms.CheckedListBox();
            this.NewDescBox = new System.Windows.Forms.TextBox();
            this.LabelAct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.newDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.notifPopup = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(86, 27);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(230, 23);
            this.titleTextBox.TabIndex = 2;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(533, 404);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Save";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(452, 404);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // testCheckBox
            // 
            this.testCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testCheckBox.ForeColor = System.Drawing.Color.Black;
            this.testCheckBox.FormattingEnabled = true;
            this.testCheckBox.Location = new System.Drawing.Point(7, 49);
            this.testCheckBox.Name = "testCheckBox";
            this.testCheckBox.Size = new System.Drawing.Size(230, 256);
            this.testCheckBox.TabIndex = 5;
            this.testCheckBox.Click += new System.EventHandler(this.testCheckBox_Click);
            // 
            // NewDescBox
            // 
            this.NewDescBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDescBox.Location = new System.Drawing.Point(86, 63);
            this.NewDescBox.Margin = new System.Windows.Forms.Padding(2);
            this.NewDescBox.Multiline = true;
            this.NewDescBox.Name = "NewDescBox";
            this.NewDescBox.Size = new System.Drawing.Size(230, 223);
            this.NewDescBox.TabIndex = 8;
            // 
            // LabelAct
            // 
            this.LabelAct.AutoSize = true;
            this.LabelAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAct.Location = new System.Drawing.Point(4, 27);
            this.LabelAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAct.Name = "LabelAct";
            this.LabelAct.Size = new System.Drawing.Size(67, 17);
            this.LabelAct.TabIndex = 9;
            this.LabelAct.Text = "Activities:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NewDescBox);
            this.groupBox1.Controls.Add(this.checkBoxTime);
            this.groupBox1.Controls.Add(this.newDateTimePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.titleTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(282, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(326, 353);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create/Edit Activity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 34);
            this.label4.TabIndex = 16;
            this.label4.Text = "Set \r\nNotification:";
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.Location = new System.Drawing.Point(86, 305);
            this.checkBoxTime.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTime.TabIndex = 17;
            this.checkBoxTime.UseVisualStyleBackColor = true;
            // 
            // newDateTimePicker
            // 
            this.newDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.newDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.newDateTimePicker.Location = new System.Drawing.Point(104, 298);
            this.newDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.newDateTimePicker.Name = "newDateTimePicker";
            this.newDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newDateTimePicker.ShowUpDown = true;
            this.newDateTimePicker.Size = new System.Drawing.Size(212, 23);
            this.newDateTimePicker.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LabelAct);
            this.groupBox2.Controls.Add(this.testCheckBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(246, 353);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Activities";
            // 
            // notifPopup
            // 
            this.notifPopup.Icon = ((System.Drawing.Icon)(resources.GetObject("notifPopup.Icon")));
            this.notifPopup.Text = "notifyIcon1";
            this.notifPopup.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "To Do App: Your Personal Activity Tracker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.CheckedListBox testCheckBox;
        private System.Windows.Forms.TextBox NewDescBox;
        private System.Windows.Forms.Label LabelAct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker newDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxTime;
        private System.Windows.Forms.NotifyIcon notifPopup;
    }
}

