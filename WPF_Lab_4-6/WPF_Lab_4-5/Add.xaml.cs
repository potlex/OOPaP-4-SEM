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
    public partial class Add : Window
    {
        public Company company;
        private Tour tour;
        private OpenFileDialog openFileDialog;
        public Add()
        {
            InitializeComponent();
            StreamResourceInfo sri = Application.GetResourceStream(new Uri("./files/green_normal.cur", UriKind.Relative));
            Cursor customCursor = new Cursor(sri.Stream);
            this.Cursor = customCursor;
            tour = new Tour();
            company = new Company();
        }

        private void button_addImg_tour_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                img_dynamic.Source = new BitmapImage(fileUri);
            }
        }

        private void button_addTo_tour_Click(object sender, RoutedEventArgs e)
        {
            Company fcom = new Company();
            tour = new Tour(tb_name_tour.Text, Convert.ToInt32(tb_price_tour.Text),
                cb_country_tour.Text, Convert.ToInt32(tb_time_tour.Text),
                cb_type_tour.Text, Convert.ToInt32(tb_rating_tour.Text),
                img_dynamic.Source.ToString(), tb_desc_tour.Text);

            var companyList = Serialize.DataDeserialize();
            if (companyList != null)
                foreach (var item in companyList.tourList)
                    fcom.Add(item);
            fcom.Add(tour);
            Serialize.DataSerialize(fcom);
            this.Close();
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
