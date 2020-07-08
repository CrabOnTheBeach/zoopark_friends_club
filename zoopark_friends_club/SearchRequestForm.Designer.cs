
namespace zoopark_friends_club
{
    partial class SearchRequestForm
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResidentName = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.Species = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(103, 280);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(163, 65);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Искать";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ResidentName
            // 
            this.ResidentName.Location = new System.Drawing.Point(103, 112);
            this.ResidentName.Name = "ResidentName";
            this.ResidentName.Size = new System.Drawing.Size(357, 20);
            this.ResidentName.TabIndex = 1;
            // 
            // Sex
            // 
            this.Sex.FormattingEnabled = true;
            this.Sex.Location = new System.Drawing.Point(339, 154);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(121, 21);
            this.Sex.TabIndex = 2;
            this.Sex.SelectedIndexChanged += new System.EventHandler(this.Sex_SelectedIndexChanged);
            // 
            // Species
            // 
            this.Species.FormattingEnabled = true;
            this.Species.Location = new System.Drawing.Point(339, 201);
            this.Species.Name = "Species";
            this.Species.Size = new System.Drawing.Size(121, 21);
            this.Species.TabIndex = 5;
            this.Species.SelectedIndexChanged += new System.EventHandler(this.Species_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // SearchRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Species);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.ResidentName);
            this.Controls.Add(this.SearchButton);
            this.Name = "SearchRequestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox ResidentName;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.ComboBox Species;
        private System.Windows.Forms.Label label1;
    }
}

