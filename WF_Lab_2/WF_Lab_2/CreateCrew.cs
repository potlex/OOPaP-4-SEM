using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Lab_2
{
    public partial class CreateCrew : Form
    {
        public static Crew crew = new Crew();
        public CreateCrew()
        {
            InitializeComponent();
        }
        public void ClearInput() 
        {
            FIO_textBox.Text = string.Empty;
            Profession_listBox.Text = "";
            Age_textBox.Text = string.Empty;
            Exp_textBox.Text = string.Empty;
        }
        public void AddCrew_button_Click(object sender, EventArgs e)
        {
            try
            {
                crew = new Crew(FIO_textBox.Text, Profession_listBox.SelectedIndex, Convert.ToInt32(Age_textBox.Text),
                    Convert.ToInt32(Exp_textBox.Text));

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
