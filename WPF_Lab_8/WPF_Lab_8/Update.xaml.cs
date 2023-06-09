using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Lab_8
{
    /// <summary>
    /// Логика взаимодействия для Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        private OpenFileDialog openFileDialog;
        private Uri fileUri;
        byte[] array;
        int[] idArray;
        public Update(object item)
        {
            InitializeComponent();
            firstNameTextBox.Text = item.GetType().GetProperty("first_name").GetValue(item).ToString();
            middleNameTextBox.Text = item.GetType().GetProperty("middle_name").GetValue(item).ToString();
            lastNameTextBox.Text = item.GetType().GetProperty("last_name").GetValue(item).ToString();
            ageTextBox.Text = item.GetType().GetProperty("age").GetValue(item).ToString();
            phoneTextBox.Text = item.GetType().GetProperty("phone").GetValue(item).ToString();
            countryTextBox.Text = item.GetType().GetProperty("country").GetValue(item).ToString();
            cityTextBox.Text = item.GetType().GetProperty("city").GetValue(item).ToString();
            streetTextBox.Text = item.GetType().GetProperty("street").GetValue(item).ToString();
            houseTextBox.Text = item.GetType().GetProperty("house").GetValue(item).ToString();
            buildTextBox.Text = item.GetType().GetProperty("build").GetValue(item).ToString();
            flatTextBox.Text = item.GetType().GetProperty("flat").GetValue(item).ToString();
            serialTextBox.Text = item.GetType().GetProperty("serial").GetValue(item).ToString();
            numberTextBox.Text = item.GetType().GetProperty("number").GetValue(item).ToString();
            array = (byte[])item.GetType().GetProperty("photo").GetValue(item);
            idArray = new int[3] {(int)item.GetType().GetProperty("id_person").GetValue(item),
                (int)item.GetType().GetProperty("id_address").GetValue(item),
                (int)item.GetType().GetProperty("id_passport").GetValue(item)};
        }

        private byte[] B64Encode()
        {
            byte[] array = Encoding.ASCII.GetBytes(fileUri.ToString());
            return array;
        }

        private void imgButton_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == true)
            {
                fileUri = new Uri(openFileDialog.FileName);
            }
        }

        private async void updateButton_Click(object sender, RoutedEventArgs e)
        {
            string getConnection = @"Data Source=localhost;Initial Catalog=oopdb;Integrated Security=True";
            SqlConnection connection = new SqlConnection(getConnection);
            connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            cmd.CommandText = "UPDATE PERSON SET first_name = @fn, middle_name = @mn, last_name = @ln, age = @ap, phone = @php WHERE id_person = " + idArray[0];
            cmd.Parameters.AddWithValue("@fn", firstNameTextBox.Text);
            cmd.Parameters.AddWithValue("@mn", middleNameTextBox.Text);
            cmd.Parameters.AddWithValue("@ln", lastNameTextBox.Text);
            cmd.Parameters.AddWithValue("@ap", Convert.ToInt32(ageTextBox.Text));
            cmd.Parameters.AddWithValue("@php", phoneTextBox.Text);

            await cmd.ExecuteNonQueryAsync();
            cmd.CommandText = "UPDATE PASSPORT SET serial = @sp, number = @np, photo = @pp WHERE id_passport = " + idArray[2];
            cmd.Parameters.AddWithValue("@sp", serialTextBox.Text);
            cmd.Parameters.AddWithValue("@np", Convert.ToInt32(numberTextBox.Text));
            cmd.Parameters.AddWithValue("@pp", fileUri == null ? array : B64Encode());

            await cmd.ExecuteNonQueryAsync();
            cmd.CommandText = "UPDATE ADDRESS SET country = @cp, city = @cip, street = @stp, house = @hp, build = @bp, flat = @fp WHERE id_address = " + idArray[1];
            cmd.Parameters.AddWithValue("@cp", countryTextBox.Text);
            cmd.Parameters.AddWithValue("@cip", cityTextBox.Text);
            cmd.Parameters.AddWithValue("@stp", streetTextBox.Text);
            cmd.Parameters.AddWithValue("@hp", Convert.ToInt32(houseTextBox.Text));
            cmd.Parameters.AddWithValue("@bp", Convert.ToInt32(buildTextBox.Text));
            cmd.Parameters.AddWithValue("@fp", Convert.ToInt32(flatTextBox.Text));

            await cmd.ExecuteNonQueryAsync();

            connection.Close();
            this.Close();
        }
    }
}
