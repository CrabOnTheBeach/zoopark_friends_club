namespace zoopark_friends_club
{
    partial class PersonalCabinet
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SupportedZoo = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SexBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BirthDayBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(85, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 204);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SupportedZoo
            // 
            this.SupportedZoo.Location = new System.Drawing.Point(85, 270);
            this.SupportedZoo.Name = "SupportedZoo";
            this.SupportedZoo.Size = new System.Drawing.Size(85, 45);
            this.SupportedZoo.TabIndex = 1;
            this.SupportedZoo.Text = "MyZooFriends";
            this.SupportedZoo.UseVisualStyleBackColor = true;
            this.SupportedZoo.Click += new System.EventHandler(this.SupportedZoo_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(183, 271);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(73, 44);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(445, 61);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 3;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SexBox
            // 
            this.SexBox.Location = new System.Drawing.Point(445, 104);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(100, 20);
            this.SexBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пол";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(445, 148);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(100, 20);
            this.NumberBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата рождения";
            // 
            // BirthDayBox
            // 
            this.BirthDayBox.Location = new System.Drawing.Point(445, 198);
            this.BirthDayBox.Name = "BirthDayBox";
            this.BirthDayBox.Size = new System.Drawing.Size(100, 20);
            this.BirthDayBox.TabIndex = 11;
            this.BirthDayBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // PersonalCabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BirthDayBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SexBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.SupportedZoo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalCabinet";
            this.Text = "PersonalCabinet";
            this.Load += new System.EventHandler(this.PersonalCabinet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SupportedZoo;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SexBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BirthDayBox;
    }
}