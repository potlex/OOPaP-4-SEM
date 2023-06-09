namespace WF_Lab_2
{
    partial class OwnerForm
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
            this.FIO_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.YearOfCreate_dtp = new System.Windows.Forms.DateTimePicker();
            this.Models_clb = new System.Windows.Forms.CheckedListBox();
            this.AddOwner_button = new System.Windows.Forms.Button();
            this.Country_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FIO_label
            // 
            this.FIO_label.AutoSize = true;
            this.FIO_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIO_label.Location = new System.Drawing.Point(25, 9);
            this.FIO_label.Name = "FIO_label";
            this.FIO_label.Size = new System.Drawing.Size(107, 25);
            this.FIO_label.TabIndex = 3;
            this.FIO_label.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Страна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Типы производимых \r\nсамолётов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Год основания";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(30, 37);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(249, 22);
            this.Name_textBox.TabIndex = 7;
            // 
            // YearOfCreate_dtp
            // 
            this.YearOfCreate_dtp.CustomFormat = "yyyy";
            this.YearOfCreate_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.YearOfCreate_dtp.Location = new System.Drawing.Point(30, 90);
            this.YearOfCreate_dtp.Name = "YearOfCreate_dtp";
            this.YearOfCreate_dtp.Size = new System.Drawing.Size(249, 22);
            this.YearOfCreate_dtp.TabIndex = 8;
            // 
            // Models_clb
            // 
            this.Models_clb.FormattingEnabled = true;
            this.Models_clb.Items.AddRange(new object[] {
            "Airbus",
            "Boeing",
            "Heinkel",
            "СУ",
            "АН",
            "ТУ"});
            this.Models_clb.Location = new System.Drawing.Point(30, 221);
            this.Models_clb.Name = "Models_clb";
            this.Models_clb.Size = new System.Drawing.Size(249, 89);
            this.Models_clb.TabIndex = 10;
            // 
            // AddOwner_button
            // 
            this.AddOwner_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOwner_button.Location = new System.Drawing.Point(30, 316);
            this.AddOwner_button.Name = "AddOwner_button";
            this.AddOwner_button.Size = new System.Drawing.Size(249, 72);
            this.AddOwner_button.TabIndex = 20;
            this.AddOwner_button.Text = "Добавить";
            this.AddOwner_button.UseVisualStyleBackColor = true;
            this.AddOwner_button.Click += new System.EventHandler(this.AddOwner_button_Click);
            // 
            // Country_textBox
            // 
            this.Country_textBox.Location = new System.Drawing.Point(30, 143);
            this.Country_textBox.Name = "Country_textBox";
            this.Country_textBox.Size = new System.Drawing.Size(249, 22);
            this.Country_textBox.TabIndex = 21;
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 398);
            this.Controls.Add(this.Country_textBox);
            this.Controls.Add(this.AddOwner_button);
            this.Controls.Add(this.Models_clb);
            this.Controls.Add(this.YearOfCreate_dtp);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIO_label);
            this.MaximumSize = new System.Drawing.Size(325, 445);
            this.MinimumSize = new System.Drawing.Size(325, 445);
            this.Name = "OwnerForm";
            this.Text = "OwnerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FIO_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.DateTimePicker YearOfCreate_dtp;
        private System.Windows.Forms.CheckedListBox Models_clb;
        private System.Windows.Forms.Button AddOwner_button;
        private System.Windows.Forms.TextBox Country_textBox;
    }
}