using System;
using System.Collections.Generic;
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
using System.Windows.Resources;
using System.Windows.Shapes;

namespace WPF_Lab_4_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool styleCheck = false;
        private bool langCheck = false;
        public MainWindow()
        {
            InitializeComponent();
            StreamResourceInfo sri = Application.GetResourceStream(new Uri("./files/green_normal.cur", UriKind.Relative));
            Cursor customCursor = new Cursor(sri.Stream);
            this.Cursor = customCursor;
        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            Add addWindow = new Add();
            addWindow.Show();
        }

        private void manage_button_Click(object sender, RoutedEventArgs e)
        {
            Manage manageWindow = new Manage();
            manageWindow.Show();
            this.Close();
        }

        private void button_swapTheme_Click(object sender, RoutedEventArgs e)
        {
            if (styleCheck == true)
            {
                var uri = new Uri("/dictionaries/LiteTheme.xaml", UriKind.Relative);
                var resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
                styleCheck = false;
            }
            else
            {
                var uri = new Uri("/dictionaries/DarkTheme.xaml", UriKind.Relative);
                var resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
                styleCheck = true;
            }
        }

        private void button_ru_lang_Click(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("/dictionaries/RussianDictionary.xaml", UriKind.Relative);
            var resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            langCheck = false;
        }

        private void button_eng_lang_Click(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("/dictionaries/EnglishDictionary.xaml", UriKind.Relative);
            var resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            langCheck = true;
        }

        private void Tunneling_MouseDown(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sender.ToString() + "\n" + e.Source.ToString() + "\n\n");
        }

        private void Outer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click to Outer!");
        }
        private void First_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("1");
        }
        private void Second_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("2");
        }
        private void Third_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("3");
        }
        private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt", true))
            {
                writer.WriteLine("Выход из приложения: " + DateTime.Now.ToShortDateString() + " " +
                DateTime.Now.ToLongTimeString());
                writer.Flush();
            }

            this.Close();
        }
    }
    public class WindowCommands
    {
        static WindowCommands()
        {
            Exit = new RoutedCommand("Exit", typeof(MainWindow));
        }
        public static RoutedCommand Exit { get; set; }
    }
}
