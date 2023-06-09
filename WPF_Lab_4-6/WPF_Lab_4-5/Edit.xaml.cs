using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using WPF_Lab_4_5.classes;

namespace WPF_Lab_4_5
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public Company company;
        public Tour tour;
        private OpenFileDialog openFileDialog;
        public bool edited;
        public Edit(Tour tourExample)
        {
            InitializeComponent();
            StreamResourceInfo sri = Application.GetResourceStream(new Uri("./files/green_normal.cur", UriKind.Relative));
            Cursor customCursor = new Cursor(sri.Stream);
            this.Cursor = customCursor;
            tour = new Tour();
            company = new Company();
            edited = false;

            tb_name_tour.Text = tourExample.Name;
            tb_price_tour.Text = tourExample.Price.ToString();
            cb_country_tour.Text = tourExample.Counrty.ToString();
            tb_time_tour.Text = tourExample.Time.ToString();
            cb_type_tour.Text = tourExample.Type.ToString();
            tb_rating_tour.Text = tourExample.Rating.ToString();
            tb_desc_tour.Text = tourExample.Description;
            try
            {
                Uri imgPath = new Uri(tourExample.Image);
                img_dynamic.Source = new BitmapImage(imgPath);
            }
            catch (Exception uriError)
            {
                MessageBox.Show(uriError.Message);
            }
        }

        private void button_editImg_tour_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                img_dynamic.Source = new BitmapImage(fileUri);
            }
        }

        private void button_editTo_tour_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tour = new Tour(tb_name_tour.Text, Convert.ToInt32(tb_price_tour.Text),
                    cb_country_tour.Text, Convert.ToInt32(tb_time_tour.Text),
                    cb_type_tour.Text, Convert.ToInt32(tb_rating_tour.Text),
                    img_dynamic.Source.ToString(), tb_desc_tour.Text);;
                edited = true;
                Close();
            }
            catch(Exception tourError)
            {
                MessageBox.Show(tourError.Message);
            }

        }

        private void escButton_Click(object sender, RoutedEventArgs e) => Close();

        private void button_clear_tour_Click(object sender, RoutedEventArgs e)
        {
            tb_name_tour.Text = "";
            tb_price_tour.Text = "";
            tb_rating_tour.Text = "";
            tb_time_tour.Text = "";
            tb_desc_tour.Text = "";
            img_dynamic.Source = null;
            cb_country_tour.Text = "";
            cb_type_tour.Text = "";
        }
    }
}
