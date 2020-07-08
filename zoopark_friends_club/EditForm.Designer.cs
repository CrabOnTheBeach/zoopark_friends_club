namespace zoopark_friends_club
{
    partial class EditForm
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
            this.FamilyCombo = new System.Windows.Forms.ComboBox();
            this.GenusCombo = new System.Windows.Forms.ComboBox();
            this.SpeciesCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FamilyText = new System.Windows.Forms.TextBox();
            this.GenusText = new System.Windows.Forms.TextBox();
            this.SpeciesText = new System.Windows.Forms.TextBox();
            this.FamilyEditButton = new System.Windows.Forms.Button();
            this.GenusEditButton = new System.Windows.Forms.Button();
            this.SpeciesEditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FamilyCombo
            // 
            this.FamilyCombo.FormattingEnabled = true;
            this.FamilyCombo.Location = new System.Drawing.Point(211, 106);
            this.FamilyCombo.Name = "FamilyCombo";
            this.FamilyCombo.Size = new System.Drawing.Size(121, 21);
            this.FamilyCombo.TabIndex = 0;
            // 
            // GenusCombo
            // 
            this.GenusCombo.FormattingEnabled = true;
            this.GenusCombo.Location = new System.Drawing.Point(211, 161);
            this.GenusCombo.Name = "GenusCombo";
            this.GenusCombo.Size = new System.Drawing.Size(121, 21);
            this.GenusCombo.TabIndex = 1;
            // 
            // SpeciesCombo
            // 
            this.SpeciesCombo.FormattingEnabled = true;
            this.SpeciesCombo.Location = new System.Drawing.Point(211, 215);
            this.SpeciesCombo.Name = "SpeciesCombo";
            this.SpeciesCombo.Size = new System.Drawing.Size(121, 21);
            this.SpeciesCombo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Семейство";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Род";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вид";
            // 
            // FamilyText
            // 
            this.FamilyText.Location = new System.Drawing.Point(400, 106);
            this.FamilyText.Name = "FamilyText";
            this.FamilyText.Size = new System.Drawing.Size(100, 20);
            this.FamilyText.TabIndex = 8;
            // 
            // GenusText
            // 
            this.GenusText.Location = new System.Drawing.Point(400, 161);
            this.GenusText.Name = "GenusText";
            this.GenusText.Size = new System.Drawing.Size(100, 20);
            this.GenusText.TabIndex = 9;
            // 
            // SpeciesText
            // 
            this.SpeciesText.Location = new System.Drawing.Point(400, 215);
            this.SpeciesText.Name = "SpeciesText";
            this.SpeciesText.Size = new System.Drawing.Size(100, 20);
            this.SpeciesText.TabIndex = 10;
            // 
            // FamilyEditButton
            // 
            this.FamilyEditButton.Location = new System.Drawing.Point(553, 104);
            this.FamilyEditButton.Name = "FamilyEditButton";
            this.FamilyEditButton.Size = new System.Drawing.Size(88, 23);
            this.FamilyEditButton.TabIndex = 12;
            this.FamilyEditButton.Text = "Изменить";
            this.FamilyEditButton.UseVisualStyleBackColor = true;
            this.FamilyEditButton.Click += new System.EventHandler(this.FamilyEditButton_Click);
            // 
            // GenusEditButton
            // 
            this.GenusEditButton.Location = new System.Drawing.Point(553, 159);
            this.GenusEditButton.Name = "GenusEditButton";
            this.GenusEditButton.Size = new System.Drawing.Size(88, 23);
            this.GenusEditButton.TabIndex = 13;
            this.GenusEditButton.Text = "Изменить";
            this.GenusEditButton.UseVisualStyleBackColor = true;
            this.GenusEditButton.Click += new System.EventHandler(this.GenusEditButton_Click);
            // 
            // SpeciesEditButton
            // 
            this.SpeciesEditButton.Location = new System.Drawing.Point(553, 213);
            this.SpeciesEditButton.Name = "SpeciesEditButton";
            this.SpeciesEditButton.Size = new System.Drawing.Size(88, 23);
            this.SpeciesEditButton.TabIndex = 14;
            this.SpeciesEditButton.Text = "Изменить";
            this.SpeciesEditButton.UseVisualStyleBackColor = true;
            this.SpeciesEditButton.Click += new System.EventHandler(this.SpeciesEditButton_Click);
            // 
            // NameCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpeciesEditButton);
            this.Controls.Add(this.GenusEditButton);
            this.Controls.Add(this.FamilyEditButton);
            this.Controls.Add(this.SpeciesText);
            this.Controls.Add(this.GenusText);
            this.Controls.Add(this.FamilyText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpeciesCombo);
            this.Controls.Add(this.GenusCombo);
            this.Controls.Add(this.FamilyCombo);
            this.Name = "NameCombo";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FamilyCombo;
        private System.Windows.Forms.ComboBox GenusCombo;
        private System.Windows.Forms.ComboBox SpeciesCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FamilyText;
        private System.Windows.Forms.TextBox GenusText;
        private System.Windows.Forms.TextBox SpeciesText;
        private System.Windows.Forms.Button FamilyEditButton;
        private System.Windows.Forms.Button GenusEditButton;
        private System.Windows.Forms.Button SpeciesEditButton;
    }
}