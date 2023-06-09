namespace WF_Lab_2
{
    public partial class CreateCrew
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
            this.FIO_textBox = new System.Windows.Forms.TextBox();
            this.FIO_label = new System.Windows.Forms.Label();
            this.Profession_label = new System.Windows.Forms.Label();
            this.Profession_listBox = new System.Windows.Forms.ListBox();
            this.Age_label = new System.Windows.Forms.Label();
            this.Age_textBox = new System.Windows.Forms.TextBox();
            this.Exp_label = new System.Windows.Forms.Label();
            this.Exp_textBox = new System.Windows.Forms.TextBox();
            this.AddCrew_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FIO_textBox
            // 
            this.FIO_textBox.Location = new System.Drawing.Point(17, 52);
            this.FIO_textBox.Name = "FIO_textBox";
            this.FIO_textBox.Size = new System.Drawing.Size(359, 22);
            this.FIO_textBox.TabIndex = 1;
            // 
            // FIO_label
            // 
            this.FIO_label.AutoSize = true;
            this.FIO_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIO_label.Location = new System.Drawing.Point(12, 24);
            this.FIO_label.Name = "FIO_label";
            this.FIO_label.Size = new System.Drawing.Size(63, 25);
            this.FIO_label.TabIndex = 2;
            this.FIO_label.Text = "ФИО";
            // 
            // Profession_label
            // 
            this.Profession_label.AutoSize = true;
            this.Profession_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Profession_label.Location = new System.Drawing.Point(12, 90);
            this.Profession_label.Name = "Profession_label";
            this.Profession_label.Size = new System.Drawing.Size(132, 25);
            this.Profession_label.TabIndex = 3;
            this.Profession_label.Text = "Должность";
            // 
            // Profession_listBox
            // 
            this.Profession_listBox.FormattingEnabled = true;
            this.Profession_listBox.ItemHeight = 16;
            this.Profession_listBox.Items.AddRange(new object[] {
            "пилот",
            "стюардесса"});
            this.Profession_listBox.Location = new System.Drawing.Point(17, 118);
            this.Profession_listBox.Name = "Profession_listBox";
            this.Profession_listBox.Size = new System.Drawing.Size(359, 52);
            this.Profession_listBox.TabIndex = 13;
            // 
            // Age_label
            // 
            this.Age_label.AutoSize = true;
            this.Age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Age_label.Location = new System.Drawing.Point(12, 185);
            this.Age_label.Name = "Age_label";
            this.Age_label.Size = new System.Drawing.Size(96, 25);
            this.Age_label.TabIndex = 14;
            this.Age_label.Text = "Возраст";
            // 
            // Age_textBox
            // 
            this.Age_textBox.Location = new System.Drawing.Point(17, 213);
            this.Age_textBox.Name = "Age_textBox";
            this.Age_textBox.Size = new System.Drawing.Size(359, 22);
            this.Age_textBox.TabIndex = 15;
            // 
            // Exp_label
            // 
            this.Exp_label.AutoSize = true;
            this.Exp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exp_label.Location = new System.Drawing.Point(12, 250);
            this.Exp_label.Name = "Exp_label";
            this.Exp_label.Size = new System.Drawing.Size(68, 25);
            this.Exp_label.TabIndex = 16;
            this.Exp_label.Text = "Стаж";
            // 
            // Exp_textBox
            // 
            this.Exp_textBox.Location = new System.Drawing.Point(17, 278);
            this.Exp_textBox.Name = "Exp_textBox";
            this.Exp_textBox.Size = new System.Drawing.Size(359, 22);
            this.Exp_textBox.TabIndex = 17;
            // 
            // AddCrew_button
            // 
            this.AddCrew_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCrew_button.Location = new System.Drawing.Point(17, 328);
            this.AddCrew_button.MaximumSize = new System.Drawing.Size(359, 71);
            this.AddCrew_button.MinimumSize = new System.Drawing.Size(359, 71);
            this.AddCrew_button.Name = "AddCrew_button";
            this.AddCrew_button.Size = new System.Drawing.Size(359, 71);
            this.AddCrew_button.TabIndex = 19;
            this.AddCrew_button.Text = "Добавить";
            this.AddCrew_button.UseVisualStyleBackColor = true;
            this.AddCrew_button.Click += new System.EventHandler(this.AddCrew_button_Click);
            // 
            // CreateCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 426);
            this.Controls.Add(this.AddCrew_button);
            this.Controls.Add(this.Exp_textBox);
            this.Controls.Add(this.Exp_label);
            this.Controls.Add(this.Age_textBox);
            this.Controls.Add(this.Age_label);
            this.Controls.Add(this.Profession_listBox);
            this.Controls.Add(this.Profession_label);
            this.Controls.Add(this.FIO_label);
            this.Controls.Add(this.FIO_textBox);
            this.MaximumSize = new System.Drawing.Size(407, 473);
            this.MinimumSize = new System.Drawing.Size(407, 473);
            this.Name = "CreateCrew";
            this.Text = "Добавить члена экипажа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FIO_textBox;
        private System.Windows.Forms.Label FIO_label;
        private System.Windows.Forms.Label Profession_label;
        private System.Windows.Forms.ListBox Profession_listBox;
        private System.Windows.Forms.Label Age_label;
        private System.Windows.Forms.TextBox Age_textBox;
        private System.Windows.Forms.Label Exp_label;
        private System.Windows.Forms.TextBox Exp_textBox;
        private System.Windows.Forms.Button AddCrew_button;
    }
}