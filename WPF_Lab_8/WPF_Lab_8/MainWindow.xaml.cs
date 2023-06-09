using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices.ComTypes;
using System.Net.NetworkInformation;
using System.Collections;
using System.Data.Entity.Infrastructure;

namespace WPF_Lab_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        oopdbEntities entity = new oopdbEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Show();
        }

        private void Show()
        {
            var query =
            from person in entity.PERSON
            join address in entity.ADDRESS
            on person.id_address equals address.id_address
            join passport in entity.PASSPORT
            on person.id_passport equals passport.id_passport
            select new
            {
                person.id_person,
                person.first_name,
                person.middle_name,
                person.last_name,
                person.age,
                person.phone,
                person.id_passport,
                person.id_address,
                address.country,
                address.city,
                address.street,
                address.house,
                address.build,
                address.flat,
                passport.serial,
                passport.number,
                passport.photo
            };
            table.ItemsSource = query.ToList();
        }

        private void insertButton_Click(object sender, RoutedEventArgs e)
        {
            Insert insert = new Insert();
            insert.ShowDialog();
            Show();
        }

        private async void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (table.SelectedItem != null)
            {
                var indexPerson = table.SelectedItem.GetType().GetProperty("id_person").GetValue(table.SelectedItem);
                var indexAddress = table.SelectedItem.GetType().GetProperty("id_address").GetValue(table.SelectedItem);
                var indexPassport = table.SelectedItem.GetType().GetProperty("id_passport").GetValue(table.SelectedItem);

                string getConnection = @"Data Source=localhost;Initial Catalog=oopdb;Integrated Security=True";

                SqlConnection connection = new SqlConnection(getConnection);
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "BEGIN TRANSACTION";
                cmd.Connection = connection;

                await cmd.ExecuteNonQueryAsync();
                cmd.CommandText = "DELETE FROM PERSON WHERE id_person = " + indexPerson;
                await cmd.ExecuteNonQueryAsync();
                cmd.CommandText = "DELETE FROM ADDRESS WHERE id_address = " + indexAddress;
                await cmd.ExecuteNonQueryAsync();
                cmd.CommandText = "DELETE FROM PASSPORT WHERE id_passport = " + indexPassport;
                await cmd.ExecuteNonQueryAsync();

                cmd.CommandText = "COMMIT";
                await cmd.ExecuteNonQueryAsync();

                connection.Close();
            }
            Show();
        }

        private void viewButton_Click(object sender, RoutedEventArgs e)
        {
            Show();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            Update update = new Update(table.SelectedItem);
            update.ShowDialog();
            Show();
        }

        private void selectButton_Click(object sender, RoutedEventArgs e)
        {
            var query =
            from person in entity.PERSON
            join address in entity.ADDRESS
            on person.id_address equals address.id_address
            join passport in entity.PASSPORT
            on person.id_passport equals passport.id_passport
            where person.age > 50
            select new
            {
                person.id_person,
                person.first_name,
                person.middle_name,
                person.last_name,
                person.age,
                person.phone,
                person.id_passport,
                person.id_address,
                address.country,
                address.city,
                address.street,
                address.house,
                address.build,
                address.flat,
                passport.serial,
                passport.number,
                passport.photo
            };
            table.ItemsSource = query.ToList();
        }

        private void procedureButton_Click(object sender, RoutedEventArgs e)
        {
            string getConnection = @"Data Source=localhost;Initial Catalog=oopdb;Integrated Security=True";

            SqlConnection connection = new SqlConnection(getConnection);
            connection.Open();
            SqlCommand cmd = new SqlCommand("EXEC SelectPerson @Age = " + ageTextBox.Text + ", @Country = '" + countryTextBox.Text + "';", connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            table.ItemsSource = dt.DefaultView;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            table.SelectedIndex = table.SelectedIndex + 1;
            if (table.SelectedIndex < 0)
                table.SelectedIndex = 0;
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            table.SelectedIndex = table.SelectedIndex - 1;
            if (table.SelectedIndex < 0)
                table.SelectedIndex = 0;
        }
    }
}
