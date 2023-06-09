using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Text.RegularExpressions.Regex;
using static System.Windows.Forms.ListView;

namespace WF_Lab_2
{
    public partial class AirportForm : Form
    {
        ToolStripStatusLabel date_SS;
        ToolStripStatusLabel time_SS;
        ToolStripStatusLabel countObj_SS;
        Timer timer;
        Airport airObject = new Airport();
        public AirportForm()
        {
            InitializeComponent();
            ClearInput();

            date_SS = new ToolStripStatusLabel();
            time_SS = new ToolStripStatusLabel();
            countObj_SS = new ToolStripStatusLabel();

            statusStrip1.Items.Add(date_SS);
            statusStrip1.Items.Add(time_SS);
            statusStrip1.Items.Add(countObj_SS);

            timer = new Timer() 
            {
                Interval = 1000 
            };
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            CountOfPeople_label.Text = Pass_trackBar.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            CountOfT_label.Text = LoadCapacity_trackBar.Value.ToString();
        }

        private void ClearInput() 
        {
            ID_textBox.Text = string.Empty;
            Type_comboBox.SelectedIndex = 0;
            Model_comboBox.SelectedIndex = 0;
            Pass_trackBar.Value = default;
            Date_listBox.SelectedIndex = 0;
            LoadCapacity_trackBar.Value = 30;
            LastTS_dateTimePicker.Value = new DateTime(2023, 2, 18);
            BuisnessClass_checkBox.Checked = false;
            Desc_textBox.Text = string.Empty;
            Crew_CLB.ClearSelected();
            Owner_CLB.ClearSelected();
        }

        private void SerializeXML(Control control)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Control));

            using (FileStream fs = new FileStream("Airport.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, control);
            }
        }

        private void SerializeXML(Control control, string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Control));

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, control);
            }
        }

        private Control DeserializeXML()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Control));

            using (FileStream fs = new FileStream("Airport.xml", FileMode.OpenOrCreate))
            {
                return (Control)xml.Deserialize(fs);
            }
        }

        private void AddS(Airport air)
        {
            ListViewItem LVI = new ListViewItem(Convert.ToString(air.ID));
            LVI.Tag = air;

            airObject.airList.Add(air);
            Air_listView.Items.Add(LVI);
        }

        
        private void Serialize_button_Click(object sender, EventArgs e)
        {
            Control control = new Control();

            foreach (ListViewItem item in Air_listView.Items)
            {
                if (item.Tag != null)
                {
                    control.airport.Add((Airport)item.Tag);
                }
            }

            SerializeXML(control);
        }

        private void Deserialize_button_Click(object sender, EventArgs e)
        {
            ClearInput();

            Control control = DeserializeXML();

            foreach (Airport air in control.airport)
            {
                AddS(air);
            }
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            //try
            //{
                Airport air = new Airport(Convert.ToInt32(ID_textBox.Text), Type_comboBox.SelectedIndex, Model_comboBox.SelectedIndex,
                     Crew_CLB.SelectedItems.ToString(), Convert.ToInt32(Pass_trackBar.Value), Convert.ToInt32(Date_listBox.SelectedItem.ToString()),
                     Convert.ToInt32(LoadCapacity_trackBar.Value), LastTS_dateTimePicker.Value,
                     BuisnessClass_checkBox.Checked, Desc_textBox.Text, Owner_CLB.SelectedItem.ToString());

                var results = new List<ValidationResult>();
                var context = new ValidationContext(air);
                if (!Validator.TryValidateObject(air, context, results, true))
                {
                    foreach (var error in results)
                    {
                        string strWithErrroe = error.ErrorMessage;
                    }
                }

                AddS(air);
                ClearInput();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Некорректные данные формы");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateCrew load = new CreateCrew();
            load.ShowDialog();
        }

        private void Air_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Air_listView.SelectedItems.Count == 1)
            {
                Airport air = (Airport)Air_listView.SelectedItems[0].Tag;

                if (air != null)
                {
                    ID_textBox.Text = Convert.ToString(air.ID);
                    Type_comboBox.SelectedIndex = Convert.ToInt32(air.Type);
                    Model_comboBox.SelectedIndex = Convert.ToInt32(air.Model);
                    Pass_trackBar.Value = air.PassCapacity;
                    LoadCapacity_trackBar.Value = air.LoadCapacity;
                    Date_listBox.SelectedItem = air.YearOfCreate;
                    LastTS_dateTimePicker.Value = air.LastTS;
                    BuisnessClass_checkBox.Checked = air.FullSet;
                    Desc_textBox.Text = air.OtherDesc;
                }
            }
            else if (Air_listView.SelectedItems.Count == 0)
            {
                ClearInput();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Crew_CLB.Items.Add(CreateCrew.crew.FIO + " " + CreateCrew.crew.Profession + " "
                                + Convert.ToString(CreateCrew.crew.Age) + " "
                                + Convert.ToString(CreateCrew.crew.Exp));
        }

        private void AddOwner_button_Click(object sender, EventArgs e)
        {
            OwnerForm own = new OwnerForm();
            own.ShowDialog();
        }
        private void RefreshOwners_button_Click(object sender, EventArgs e)
        {
            Owner_CLB.Items.Add(OwnerForm.owner.Name + " " + OwnerForm.owner.Year + " " +
                OwnerForm.owner.Country + " " + OwnerForm.owner.Types);
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            search_listView.Clear();
            Regex regesAir = new Regex($@"{search_textBox.Text}(\w*)");
            MatchCollection matchAir;
            if (search_comboBox.SelectedIndex == 0)
            {
                foreach (var item in airObject.airList)
                {
                    matchAir = regesAir.Matches(item.Owner);
                    if (matchAir.Count > 0)
                    {
                        foreach (Match match in matchAir)
                            search_listView.Items.Add(item.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Совпадений не найдено!");
                    }
                }
            }
            else if (search_comboBox.SelectedIndex == 1)
            {
                foreach (var item in airObject.airList)
                {
                    matchAir = regesAir.Matches(item.Type.ToString());
                    if (matchAir.Count > 0)
                    {
                        foreach (Match match in matchAir)
                            search_listView.Items.Add(item.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Совпадений не найдено!");
                    }
                }
            }
            else if (search_comboBox.SelectedIndex == 2)
            {
                foreach (var item in airObject.airList)
                {
                    matchAir = regesAir.Matches(item.PassCapacity.ToString());
                    if (matchAir.Count > 0)
                    {
                        foreach (Match match in matchAir)
                            search_listView.Items.Add(item.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Совпадений не найдено!");
                    }
                }
            }
            else if (search_comboBox.SelectedIndex == 3)
            {
                foreach (var item in airObject.airList)
                {
                    matchAir = regesAir.Matches(item.LoadCapacity.ToString());
                    if (matchAir.Count > 0)
                    {
                        foreach (Match match in matchAir)
                            search_listView.Items.Add(item.ID.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Совпадений не найдено!");
                    }
                }
            }
        }
        
        private void sort_button_Click(object sender, EventArgs e)
        {
            sort_listView.Clear();
            List<Airport> sortedAir = new List<Airport>();
            if (sort_listBox.SelectedIndex == 0)
            {
                sortedAir = airObject.airList.OrderBy(x => x.YearOfCreate).ToList();
            }
            else if(sort_listBox.SelectedIndex == 1)
            {
                sortedAir = airObject.airList.OrderBy(x => x.LastTS).ToList();
            }
            foreach (var airr in sortedAir)
            {
                ListViewItem LVI = new ListViewItem(Convert.ToString(airr.ID));
                LVI.Tag = airr;
                sort_listView.Items.Add(LVI);
            }
        }

        private void SerializeSortResult_Click(object sender, EventArgs e)
        {
            Control control = new Control();

            foreach (ListViewItem item in sort_listView.Items)
            {
                if (item.Tag != null)
                {
                    control.airport.Add((Airport)item.Tag);
                }
            }

            SerializeXML(control, "sortedAirports.xml");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия 17.4.5\n" +
                "Потапович Алексей Викторович");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ID_textBox.Text = string.Empty;
            Type_comboBox.SelectedIndex = 0;
            Model_comboBox.SelectedIndex = 0;
            Pass_trackBar.Value = default;
            CountOfPeople_label.Text = "0";
            Date_listBox.SelectedIndex = 0;
            LoadCapacity_trackBar.Value = 30;
            CountOfT_label.Text = "30";
            LastTS_dateTimePicker.Value = new DateTime(2023, 2, 18);
            BuisnessClass_checkBox.Checked = false;
            Desc_textBox.Text = string.Empty;
            Crew_CLB.ClearSelected();
            Owner_CLB.ClearSelected();
            search_listView.Clear();
            sort_listView.Clear();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
            open_ts.Visible = true;
        }

        private void open_ts_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
            open_ts.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            search_listView.Clear();
            Regex regesAir = new Regex($@"{search_textBox.Text}(\w*)");
            MatchCollection matchAir;
            if (search_comboBox.SelectedIndex == 0)
            {
                foreach (var item in airObject.airList)
                {
                    matchAir = regesAir.Matches(item.Owner);
                    if (matchAir.Count > 0)
                    {
                        foreach (Match match in matchAir)
                            search_listView.Items.Add(item.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Совпадений не найдено!");
                    }
                }
            }
            else if (search_comboBox.SelectedIndex == 1)
            {
                foreach (var item in airObject.airList)
                {
                    matchAir = regesAir.Matches(item.Type.ToString());
                    if (matchAir.Count > 0)
                    {
                        foreach (Match match in matchAir)
                            search_listView.Items.Add(item.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Совпадений не найдено!");
                    }
                }
            }
            else if (search_comboBox.SelectedIndex == 2)
            {
                foreach (var item in airObject.airList)
                {
                    matchAir = regesAir.Matches(item.PassCapacity.ToString());
                    if (matchAir.Count > 0)
                    {
                        foreach (Match match in matchAir)
                            search_listView.Items.Add(item.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Совпадений не найдено!");
                    }
                }
            }
            else if (search_comboBox.SelectedIndex == 3)
            {
                foreach (var item in airObject.airList)
                {
                    matchAir = regesAir.Matches(item.LoadCapacity.ToString());
                    if (matchAir.Count > 0)
                    {
                        foreach (Match match in matchAir)
                            search_listView.Items.Add(item.ID.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Совпадений не найдено!");
                    }
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            sort_listView.Clear();
            List<Airport> sortedAir = new List<Airport>();
            if (sort_listBox.SelectedIndex == 0)
            {
                sortedAir = airObject.airList.OrderBy(x => x.YearOfCreate).ToList();
            }
            else if (sort_listBox.SelectedIndex == 1)
            {
                sortedAir = airObject.airList.OrderBy(x => x.LastTS).ToList();
            }
            foreach (var airr in sortedAir)
            {
                ListViewItem LVI = new ListViewItem(Convert.ToString(airr.ID));
                LVI.Tag = airr;
                sort_listView.Items.Add(LVI);
            }
        }
        void timer_Tick(object sender, EventArgs e)
        {
            date_SS.Text = DateTime.Now.ToLongDateString();
            time_SS.Text = DateTime.Now.ToLongTimeString();
            countObj_SS.Text = Air_listView.Items.Count.ToString();
        }

        private void dateCheck_bn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|
                                  3[0-1])\/(0[1-9]|1[0-2])
                                  \/((19|20)\d\d))$");

            bool isValid = regex.IsMatch(dateCheck_tb.Text.Trim());

            DateTime dt;
            isValid = DateTime.TryParseExact(dateCheck_tb.Text, "dd.MM.yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
            if (!isValid)
            {
                MessageBox.Show("Неверная дата.");
            }
        }
    }
}
