namespace zoopark_friends_club
{
    partial class RegisterForm
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
            this.NameField = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(385, 109);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(100, 20);
            this.NameField.TabIndex = 0;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(385, 148);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumber.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(385, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // Sex
            // 
            this.Sex.FormattingEnabled = true;
            this.Sex.Location = new System.Drawing.Point(385, 223);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(121, 21);
            this.Sex.TabIndex = 3;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(265, 112);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(29, 13);
            this.LabelName.TabIndex = 4;
            this.LabelName.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пол";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.RegisterButton.Location = new System.Drawing.Point(345, 279);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(94, 41);
            this.RegisterButton.TabIndex = 8;
            this.RegisterButton.Text = "Регистрация";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.NameField);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RegisterButton;
    }
}