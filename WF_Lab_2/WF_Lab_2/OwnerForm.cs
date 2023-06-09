using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Lab_2
{
    public partial class OwnerForm : Form
    {
        public static Owner owner = new Owner();
        public OwnerForm()
        {
            InitializeComponent();
        }
        public void ClearInput()
        {
            Name_textBox.Text = string.Empty;
            YearOfCreate_dtp.Value = new DateTime(2023);
            Country_textBox.Text = string.Empty;
            Models_clb.ClearSelected();
        }

        private void AddOwner_button_Click(object sender, EventArgs e)
        {
            try
            {
                string[] owners = { Convert.ToString(Models_clb.CheckedItems[0]), Convert.ToString(Models_clb.CheckedItems[1]) };
                owner = new Owner(Name_textBox.Text, YearOfCreate_dtp.Value, Country_textBox.Text,
                    owners);

                ClearInput();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }
    }
}
