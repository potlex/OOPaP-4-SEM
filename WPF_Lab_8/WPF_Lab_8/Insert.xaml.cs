using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
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
    /// Логика взаимодействия для Insert.xaml
    /// </summary>
    public partial class Insert : Window
    {
        oopdbEntities entity = new oopdbEntities();
        private OpenFileDialog openFileDialog;
        private Uri fileUri;
        public Insert()
        {
            InitializeComponent();
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

        private byte[] B64Encode()
        {
            byte[] array = Encoding.ASCII.GetBytes(fileUri.ToString());
            return array;
        }

        private async void insertButton_Click(object sender, RoutedEventArgs e)
        { 
            string getConnection = @"Data Source=localhost;Initial Catalog=oopdb;Integrated Security=True";
            SqlConnection connection = new SqlConnection(getConnection);
            connection.Open();

            SqlCommand trans = new SqlCommand();
            trans.CommandText = "BEGIN TRANSACTION";
            trans.Connection = connection;

            await trans.ExecuteNonQueryAsync();
            SqlCommand addPassport = new SqlCommand();
            addPassport.CommandText = "INSERT INTO PASSPORT (serial, number, photo)values(@sp,@np,@pp)";
            addPassport.Connection = connection;
            addPassport.Parameters.AddWithValue("@sp", serialTextBox.Text);
            addPassport.Parameters.AddWithValue("@np", Convert.ToInt32(numberTextBox.Text));
            addPassport.Parameters.AddWithValue("@pp", B64Encode());
            await addPassport.ExecuteNonQueryAsync();

            SqlCommand addAddress = new SqlCommand();
            addAddress.CommandText = "INSERT INTO ADDRESS (country, city, street, house, build, flat)values(@cp,@cip,@stp,@hp,@bp,@fp)";
            addAddress.Connection = connection;
            addAddress.Parameters.AddWithValue("@cp", countryTextBox.Text);
            addAddress.Parameters.AddWithValue("@cip", cityTextBox.Text);
            addAddress.Parameters.AddWithValue("@stp", streetTextBox.Text);
            addAddress.Parameters.AddWithValue("@hp", Convert.ToInt32(houseTextBox.Text));
            addAddress.Parameters.AddWithValue("@bp", Convert.ToInt32(buildTextBox.Text));
            addAddress.Parameters.AddWithValue("@fp", Convert.ToInt32(flatTextBox.Text));
            await addAddress.ExecuteNonQueryAsync();

            trans.CommandText = "COMMIT";
            await trans.ExecuteNonQueryAsync();

            var id_address = (from dataAddress in entity.ADDRESS
                             where dataAddress.country == countryTextBox.Text &&
                             dataAddress.city == cityTextBox.Text &&
                             dataAddress.street == streetTextBox.Text &&
                             dataAddress.house.ToString().Equals(houseTextBox.Text) &&
                             dataAddress.build.ToString().Equals(buildTextBox.Text) &&
                             dataAddress.flat.ToString().Equals(flatTextBox.Text)
                             select dataAddress.id_address).FirstOrDefault<int>();
            var id_passport = (from dataPassport in entity.PASSPORT
                              where dataPassport.serial == serialTextBox.Text &&
                              dataPassport.number.ToString().Equals(numberTextBox.Text)
                              select dataPassport.id_passport).FirstOrDefault<int>();

            trans.CommandText = "BEGIN TRANSACTION";
            await trans.ExecuteNonQueryAsync();

            SqlCommand addPerson = new SqlCommand();
            addPerson.CommandText = "INSERT INTO PERSON (first_name, middle_name, last_name, age, phone, id_address, id_passport)values(@fn,@mn,@ln,@ap,@php,@ia,@ip)";
            addPerson.Connection = connection;
            addPerson.Parameters.AddWithValue("@fn", firstNameTextBox.Text);
            addPerson.Parameters.AddWithValue("@mn", middleNameTextBox.Text);
            addPerson.Parameters.AddWithValue("@ln", lastNameTextBox.Text);
            addPerson.Parameters.AddWithValue("@ap", Convert.ToInt32(ageTextBox.Text));
            addPerson.Parameters.AddWithValue("@php", phoneTextBox.Text);
            addPerson.Parameters.AddWithValue("@ia", id_address);
            addPerson.Parameters.AddWithValue("@ip", id_passport);
            await addPerson.ExecuteNonQueryAsync();

            trans.CommandText = "COMMIT";
            await trans.ExecuteNonQueryAsync();

            connection.Close();
            this.Close();
        }
    }
}
