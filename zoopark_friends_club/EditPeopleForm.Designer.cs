namespace zoopark_friends_club
{
    partial class EditPeopleForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SexBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Save = new System.Windows.Forms.Button();
            this.ChoosePic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Номер телефона";
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(517, 180);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(100, 20);
            this.NumberBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Пол";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Имя";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(517, 93);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(157, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 204);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // SexBox
            // 
            this.SexBox.FormattingEnabled = true;
            this.SexBox.Location = new System.Drawing.Point(517, 136);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(121, 21);
            this.SexBox.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(517, 233);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(453, 335);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(164, 55);
            this.Save.TabIndex = 22;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ChoosePic
            // 
            this.ChoosePic.Location = new System.Drawing.Point(184, 335);
            this.ChoosePic.Name = "ChoosePic";
            this.ChoosePic.Size = new System.Drawing.Size(121, 55);
            this.ChoosePic.TabIndex = 23;
            this.ChoosePic.Text = "Выбрать картинку";
            this.ChoosePic.UseVisualStyleBackColor = true;
            this.ChoosePic.Click += new System.EventHandler(this.ChoosePic_Click);
            // 
            // EditPeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChoosePic);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SexBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EditPeopleForm";
            this.Text = "EditPeopleForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox SexBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button ChoosePic;
    }
}