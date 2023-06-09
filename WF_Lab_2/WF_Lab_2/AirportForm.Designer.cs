using System;

namespace WF_Lab_2
{
    public partial class AirportForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirportForm));
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.ID_label = new System.Windows.Forms.Label();
            this.Type_comboBox = new System.Windows.Forms.ComboBox();
            this.Type_label = new System.Windows.Forms.Label();
            this.Model_label = new System.Windows.Forms.Label();
            this.Model_comboBox = new System.Windows.Forms.ComboBox();
            this.Crew_label = new System.Windows.Forms.Label();
            this.Pass_trackBar = new System.Windows.Forms.TrackBar();
            this.PassCapacity_label = new System.Windows.Forms.Label();
            this.CountOfPeople_label = new System.Windows.Forms.Label();
            this.Date_listBox = new System.Windows.Forms.ListBox();
            this.LoadCapacity_trackBar = new System.Windows.Forms.TrackBar();
            this.LoadCapacity_label = new System.Windows.Forms.Label();
            this.CountOfT_label = new System.Windows.Forms.Label();
            this.LastTS_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLastTS_label = new System.Windows.Forms.Label();
            this.CheckSet_label = new System.Windows.Forms.Label();
            this.BuisnessClass_checkBox = new System.Windows.Forms.CheckBox();
            this.Description_label = new System.Windows.Forms.Label();
            this.Desc_textBox = new System.Windows.Forms.TextBox();
            this.YearOfCreate_label = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.Serialize_button = new System.Windows.Forms.Button();
            this.Deserialize_button = new System.Windows.Forms.Button();
            this.Air_listView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.Crew_CLB = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Owner_CLB = new System.Windows.Forms.CheckedListBox();
            this.Owner_label = new System.Windows.Forms.Label();
            this.AddOwner_button = new System.Windows.Forms.Button();
            this.RefreshOwners_button = new System.Windows.Forms.Button();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.search_label = new System.Windows.Forms.Label();
            this.sort_label = new System.Windows.Forms.Label();
            this.sort_listBox = new System.Windows.Forms.ComboBox();
            this.search_listView = new System.Windows.Forms.ListView();
            this.search_comboBox = new System.Windows.Forms.ComboBox();
            this.search_button = new System.Windows.Forms.Button();
            this.sort_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.sort_listView = new System.Windows.Forms.ListView();
            this.SerializeSortResult = new System.Windows.Forms.Button();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.open_ts = new System.Windows.Forms.Button();
            this.dateCheck_tb = new System.Windows.Forms.TextBox();
            this.dateCheck_bn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadCapacity_trackBar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(22, 75);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(315, 21);
            this.ID_textBox.TabIndex = 0;
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_label.Location = new System.Drawing.Point(18, 49);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(33, 25);
            this.ID_label.TabIndex = 1;
            this.ID_label.Text = "ID";
            // 
            // Type_comboBox
            // 
            this.Type_comboBox.FormattingEnabled = true;
            this.Type_comboBox.Items.AddRange(new object[] {
            "пассажирский",
            "грузовой",
            "военный"});
            this.Type_comboBox.Location = new System.Drawing.Point(22, 128);
            this.Type_comboBox.Name = "Type_comboBox";
            this.Type_comboBox.Size = new System.Drawing.Size(315, 23);
            this.Type_comboBox.TabIndex = 2;
            // 
            // Type_label
            // 
            this.Type_label.AutoSize = true;
            this.Type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type_label.Location = new System.Drawing.Point(18, 101);
            this.Type_label.Name = "Type_label";
            this.Type_label.Size = new System.Drawing.Size(156, 25);
            this.Type_label.TabIndex = 3;
            this.Type_label.Text = "Тип самолёта";
            // 
            // Model_label
            // 
            this.Model_label.AutoSize = true;
            this.Model_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Model_label.Location = new System.Drawing.Point(18, 156);
            this.Model_label.Name = "Model_label";
            this.Model_label.Size = new System.Drawing.Size(90, 25);
            this.Model_label.TabIndex = 5;
            this.Model_label.Text = "Модель";
            // 
            // Model_comboBox
            // 
            this.Model_comboBox.FormattingEnabled = true;
            this.Model_comboBox.Items.AddRange(new object[] {
            "Airbus",
            "Boeing",
            "Heinkel",
            "СУ",
            "АН",
            "ТУ"});
            this.Model_comboBox.Location = new System.Drawing.Point(22, 182);
            this.Model_comboBox.Name = "Model_comboBox";
            this.Model_comboBox.Size = new System.Drawing.Size(315, 23);
            this.Model_comboBox.TabIndex = 4;
            // 
            // Crew_label
            // 
            this.Crew_label.AutoSize = true;
            this.Crew_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Crew_label.Location = new System.Drawing.Point(18, 209);
            this.Crew_label.Name = "Crew_label";
            this.Crew_label.Size = new System.Drawing.Size(91, 25);
            this.Crew_label.TabIndex = 7;
            this.Crew_label.Text = "Экипаж";
            // 
            // Pass_trackBar
            // 
            this.Pass_trackBar.AccessibleName = "";
            this.Pass_trackBar.Location = new System.Drawing.Point(22, 321);
            this.Pass_trackBar.Maximum = 360;
            this.Pass_trackBar.Name = "Pass_trackBar";
            this.Pass_trackBar.Size = new System.Drawing.Size(314, 56);
            this.Pass_trackBar.TabIndex = 9;
            this.Pass_trackBar.Value = 10;
            this.Pass_trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // PassCapacity_label
            // 
            this.PassCapacity_label.AutoSize = true;
            this.PassCapacity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassCapacity_label.Location = new System.Drawing.Point(18, 294);
            this.PassCapacity_label.Name = "PassCapacity_label";
            this.PassCapacity_label.Size = new System.Drawing.Size(260, 25);
            this.PassCapacity_label.TabIndex = 10;
            this.PassCapacity_label.Text = "Количество пассажиров";
            // 
            // CountOfPeople_label
            // 
            this.CountOfPeople_label.AutoSize = true;
            this.CountOfPeople_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountOfPeople_label.Location = new System.Drawing.Point(312, 294);
            this.CountOfPeople_label.Name = "CountOfPeople_label";
            this.CountOfPeople_label.Size = new System.Drawing.Size(24, 25);
            this.CountOfPeople_label.TabIndex = 11;
            this.CountOfPeople_label.Text = "0";
            // 
            // Date_listBox
            // 
            this.Date_listBox.FormattingEnabled = true;
            this.Date_listBox.ItemHeight = 15;
            this.Date_listBox.Items.AddRange(new object[] {
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.Date_listBox.Location = new System.Drawing.Point(22, 396);
            this.Date_listBox.Name = "Date_listBox";
            this.Date_listBox.Size = new System.Drawing.Size(315, 34);
            this.Date_listBox.TabIndex = 12;
            // 
            // LoadCapacity_trackBar
            // 
            this.LoadCapacity_trackBar.AccessibleName = "";
            this.LoadCapacity_trackBar.Location = new System.Drawing.Point(22, 482);
            this.LoadCapacity_trackBar.Maximum = 120;
            this.LoadCapacity_trackBar.Minimum = 18;
            this.LoadCapacity_trackBar.Name = "LoadCapacity_trackBar";
            this.LoadCapacity_trackBar.Size = new System.Drawing.Size(314, 56);
            this.LoadCapacity_trackBar.TabIndex = 13;
            this.LoadCapacity_trackBar.Value = 18;
            this.LoadCapacity_trackBar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // LoadCapacity_label
            // 
            this.LoadCapacity_label.AutoSize = true;
            this.LoadCapacity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadCapacity_label.Location = new System.Drawing.Point(18, 456);
            this.LoadCapacity_label.Name = "LoadCapacity_label";
            this.LoadCapacity_label.Size = new System.Drawing.Size(251, 25);
            this.LoadCapacity_label.TabIndex = 14;
            this.LoadCapacity_label.Text = "Грузоподъёмность (т.)";
            // 
            // CountOfT_label
            // 
            this.CountOfT_label.AutoSize = true;
            this.CountOfT_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountOfT_label.Location = new System.Drawing.Point(312, 456);
            this.CountOfT_label.Name = "CountOfT_label";
            this.CountOfT_label.Size = new System.Drawing.Size(36, 25);
            this.CountOfT_label.TabIndex = 15;
            this.CountOfT_label.Text = "30";
            // 
            // LastTS_dateTimePicker
            // 
            this.LastTS_dateTimePicker.Location = new System.Drawing.Point(398, 75);
            this.LastTS_dateTimePicker.MaxDate = new System.DateTime(2023, 2, 19, 0, 0, 0, 0);
            this.LastTS_dateTimePicker.MinDate = new System.DateTime(2018, 2, 19, 0, 0, 0, 0);
            this.LastTS_dateTimePicker.Name = "LastTS_dateTimePicker";
            this.LastTS_dateTimePicker.Size = new System.Drawing.Size(315, 21);
            this.LastTS_dateTimePicker.TabIndex = 16;
            this.LastTS_dateTimePicker.Value = new System.DateTime(2023, 2, 19, 0, 0, 0, 0);
            // 
            // DateLastTS_label
            // 
            this.DateLastTS_label.AutoSize = true;
            this.DateLastTS_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLastTS_label.Location = new System.Drawing.Point(394, 49);
            this.DateLastTS_label.Name = "DateLastTS_label";
            this.DateLastTS_label.Size = new System.Drawing.Size(159, 25);
            this.DateLastTS_label.TabIndex = 17;
            this.DateLastTS_label.Text = "Последнее ТО";
            // 
            // CheckSet_label
            // 
            this.CheckSet_label.AutoSize = true;
            this.CheckSet_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckSet_label.Location = new System.Drawing.Point(394, 101);
            this.CheckSet_label.Name = "CheckSet_label";
            this.CheckSet_label.Size = new System.Drawing.Size(199, 25);
            this.CheckSet_label.TabIndex = 19;
            this.CheckSet_label.Text = "Полный комплект";
            // 
            // BuisnessClass_checkBox
            // 
            this.BuisnessClass_checkBox.AutoSize = true;
            this.BuisnessClass_checkBox.Location = new System.Drawing.Point(398, 131);
            this.BuisnessClass_checkBox.Name = "BuisnessClass_checkBox";
            this.BuisnessClass_checkBox.Size = new System.Drawing.Size(105, 19);
            this.BuisnessClass_checkBox.TabIndex = 20;
            this.BuisnessClass_checkBox.Text = "бизнес-класс";
            this.BuisnessClass_checkBox.UseVisualStyleBackColor = true;
            // 
            // Description_label
            // 
            this.Description_label.AutoSize = true;
            this.Description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description_label.Location = new System.Drawing.Point(394, 156);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(288, 25);
            this.Description_label.TabIndex = 21;
            this.Description_label.Text = "Дополнительное описание";
            // 
            // Desc_textBox
            // 
            this.Desc_textBox.Location = new System.Drawing.Point(398, 184);
            this.Desc_textBox.Name = "Desc_textBox";
            this.Desc_textBox.Size = new System.Drawing.Size(315, 21);
            this.Desc_textBox.TabIndex = 22;
            // 
            // YearOfCreate_label
            // 
            this.YearOfCreate_label.AutoSize = true;
            this.YearOfCreate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearOfCreate_label.Location = new System.Drawing.Point(18, 370);
            this.YearOfCreate_label.Name = "YearOfCreate_label";
            this.YearOfCreate_label.Size = new System.Drawing.Size(137, 25);
            this.YearOfCreate_label.TabIndex = 23;
            this.YearOfCreate_label.Text = "Год выпуска";
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(601, 220);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(111, 67);
            this.Add_button.TabIndex = 18;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Serialize_button
            // 
            this.Serialize_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Serialize_button.Location = new System.Drawing.Point(398, 294);
            this.Serialize_button.Name = "Serialize_button";
            this.Serialize_button.Size = new System.Drawing.Size(314, 38);
            this.Serialize_button.TabIndex = 24;
            this.Serialize_button.Text = "Сериализация";
            this.Serialize_button.UseVisualStyleBackColor = true;
            this.Serialize_button.Click += new System.EventHandler(this.Serialize_button_Click);
            // 
            // Deserialize_button
            // 
            this.Deserialize_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deserialize_button.Location = new System.Drawing.Point(398, 339);
            this.Deserialize_button.Name = "Deserialize_button";
            this.Deserialize_button.Size = new System.Drawing.Size(314, 38);
            this.Deserialize_button.TabIndex = 25;
            this.Deserialize_button.Text = "Десериализация";
            this.Deserialize_button.UseVisualStyleBackColor = true;
            this.Deserialize_button.Click += new System.EventHandler(this.Deserialize_button_Click);
            // 
            // Air_listView
            // 
            this.Air_listView.HideSelection = false;
            this.Air_listView.Location = new System.Drawing.Point(398, 383);
            this.Air_listView.Name = "Air_listView";
            this.Air_listView.Size = new System.Drawing.Size(315, 298);
            this.Air_listView.TabIndex = 26;
            this.Air_listView.UseCompatibleStateImageBehavior = false;
            this.Air_listView.SelectedIndexChanged += new System.EventHandler(this.Air_listView_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(498, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 68);
            this.button1.TabIndex = 28;
            this.button1.Text = "Добавить\r\nэкипаж";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Crew_CLB
            // 
            this.Crew_CLB.FormattingEnabled = true;
            this.Crew_CLB.Items.AddRange(new object[] {
            "Стасенко Виктор Сергеевич пилот 35 8",
            "Григоренко Сергей Анатольевич пилот 56 24",
            "Фалько Анастасия Викторовна стюардесса 24 4"});
            this.Crew_CLB.Location = new System.Drawing.Point(22, 235);
            this.Crew_CLB.Name = "Crew_CLB";
            this.Crew_CLB.Size = new System.Drawing.Size(315, 36);
            this.Crew_CLB.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(398, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 68);
            this.button2.TabIndex = 31;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Owner_CLB
            // 
            this.Owner_CLB.FormattingEnabled = true;
            this.Owner_CLB.Items.AddRange(new object[] {
            "TurkishAirlines 1970 Turkish АН СУ",
            "FDG 1981 Denmark АН"});
            this.Owner_CLB.Location = new System.Drawing.Point(22, 547);
            this.Owner_CLB.Name = "Owner_CLB";
            this.Owner_CLB.Size = new System.Drawing.Size(315, 36);
            this.Owner_CLB.TabIndex = 32;
            // 
            // Owner_label
            // 
            this.Owner_label.AutoSize = true;
            this.Owner_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Owner_label.Location = new System.Drawing.Point(18, 520);
            this.Owner_label.Name = "Owner_label";
            this.Owner_label.Size = new System.Drawing.Size(172, 25);
            this.Owner_label.TabIndex = 33;
            this.Owner_label.Text = "Производитель";
            // 
            // AddOwner_button
            // 
            this.AddOwner_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOwner_button.Location = new System.Drawing.Point(22, 612);
            this.AddOwner_button.Name = "AddOwner_button";
            this.AddOwner_button.Size = new System.Drawing.Size(158, 68);
            this.AddOwner_button.TabIndex = 34;
            this.AddOwner_button.Text = "Добавить\r\nпроизводителя";
            this.AddOwner_button.UseVisualStyleBackColor = true;
            this.AddOwner_button.Click += new System.EventHandler(this.AddOwner_button_Click);
            // 
            // RefreshOwners_button
            // 
            this.RefreshOwners_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshOwners_button.Location = new System.Drawing.Point(186, 612);
            this.RefreshOwners_button.Name = "RefreshOwners_button";
            this.RefreshOwners_button.Size = new System.Drawing.Size(150, 68);
            this.RefreshOwners_button.TabIndex = 35;
            this.RefreshOwners_button.Text = "Обновить";
            this.RefreshOwners_button.UseVisualStyleBackColor = true;
            this.RefreshOwners_button.Click += new System.EventHandler(this.RefreshOwners_button_Click);
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(775, 101);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(315, 21);
            this.search_textBox.TabIndex = 36;
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_label.Location = new System.Drawing.Point(771, 49);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(73, 25);
            this.search_label.TabIndex = 37;
            this.search_label.Text = "Поиск";
            // 
            // sort_label
            // 
            this.sort_label.AutoSize = true;
            this.sort_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sort_label.Location = new System.Drawing.Point(772, 272);
            this.sort_label.Name = "sort_label";
            this.sort_label.Size = new System.Drawing.Size(132, 25);
            this.sort_label.TabIndex = 38;
            this.sort_label.Text = "Сортировка";
            // 
            // sort_listBox
            // 
            this.sort_listBox.FormattingEnabled = true;
            this.sort_listBox.Items.AddRange(new object[] {
            "по году выпуска ",
            "дате последнего тех. обслуживания"});
            this.sort_listBox.Location = new System.Drawing.Point(776, 298);
            this.sort_listBox.Name = "sort_listBox";
            this.sort_listBox.Size = new System.Drawing.Size(315, 23);
            this.sort_listBox.TabIndex = 39;
            // 
            // search_listView
            // 
            this.search_listView.HideSelection = false;
            this.search_listView.Location = new System.Drawing.Point(775, 159);
            this.search_listView.Name = "search_listView";
            this.search_listView.Size = new System.Drawing.Size(315, 96);
            this.search_listView.TabIndex = 40;
            this.search_listView.UseCompatibleStateImageBehavior = false;
            // 
            // search_comboBox
            // 
            this.search_comboBox.FormattingEnabled = true;
            this.search_comboBox.Items.AddRange(new object[] {
            "авиакомпании",
            "типу",
            "количеству мест",
            "грузоподъемности"});
            this.search_comboBox.Location = new System.Drawing.Point(775, 75);
            this.search_comboBox.Name = "search_comboBox";
            this.search_comboBox.Size = new System.Drawing.Size(315, 23);
            this.search_comboBox.TabIndex = 41;
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_button.Location = new System.Drawing.Point(775, 128);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(314, 25);
            this.search_button.TabIndex = 42;
            this.search_button.Text = "Поиск";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // sort_button
            // 
            this.sort_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sort_button.Location = new System.Drawing.Point(777, 325);
            this.sort_button.Name = "sort_button";
            this.sort_button.Size = new System.Drawing.Size(314, 25);
            this.sort_button.TabIndex = 43;
            this.sort_button.Text = "Сортировка";
            this.sort_button.UseVisualStyleBackColor = true;
            this.sort_button.Click += new System.EventHandler(this.sort_button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(777, 489);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(314, 38);
            this.button4.TabIndex = 45;
            this.button4.Text = "О программе";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sort_listView
            // 
            this.sort_listView.HideSelection = false;
            this.sort_listView.Location = new System.Drawing.Point(774, 356);
            this.sort_listView.Name = "sort_listView";
            this.sort_listView.Size = new System.Drawing.Size(315, 96);
            this.sort_listView.TabIndex = 46;
            this.sort_listView.UseCompatibleStateImageBehavior = false;
            // 
            // SerializeSortResult
            // 
            this.SerializeSortResult.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SerializeSortResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SerializeSortResult.Location = new System.Drawing.Point(777, 458);
            this.SerializeSortResult.Name = "SerializeSortResult";
            this.SerializeSortResult.Size = new System.Drawing.Size(314, 25);
            this.SerializeSortResult.TabIndex = 47;
            this.SerializeSortResult.Text = "Сериализация";
            this.SerializeSortResult.UseVisualStyleBackColor = true;
            this.SerializeSortResult.Click += new System.EventHandler(this.SerializeSortResult_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 692);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1112, 26);
            this.statusStrip1.TabIndex = 48;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(177, 20);
            this.toolStripStatusLabel1.Text = "Текующая дата и время:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1112, 27);
            this.toolStrip1.TabIndex = 49;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "search_ts";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "sort_ts";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "clear_ts";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "back_ts";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "forward_ts";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Margin = new System.Windows.Forms.Padding(800, 1, 0, 2);
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // open_ts
            // 
            this.open_ts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("open_ts.BackgroundImage")));
            this.open_ts.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.open_ts.FlatAppearance.BorderSize = 0;
            this.open_ts.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.open_ts.Location = new System.Drawing.Point(956, 1);
            this.open_ts.Name = "open_ts";
            this.open_ts.Size = new System.Drawing.Size(24, 24);
            this.open_ts.TabIndex = 0;
            this.open_ts.UseVisualStyleBackColor = true;
            this.open_ts.Visible = false;
            this.open_ts.Click += new System.EventHandler(this.open_ts_Click);
            // 
            // dateCheck_tb
            // 
            this.dateCheck_tb.Location = new System.Drawing.Point(774, 584);
            this.dateCheck_tb.Name = "dateCheck_tb";
            this.dateCheck_tb.Size = new System.Drawing.Size(315, 21);
            this.dateCheck_tb.TabIndex = 50;
            // 
            // dateCheck_bn
            // 
            this.dateCheck_bn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCheck_bn.Location = new System.Drawing.Point(777, 612);
            this.dateCheck_bn.Name = "dateCheck_bn";
            this.dateCheck_bn.Size = new System.Drawing.Size(314, 38);
            this.dateCheck_bn.TabIndex = 51;
            this.dateCheck_bn.Text = "О программе";
            this.dateCheck_bn.UseVisualStyleBackColor = true;
            this.dateCheck_bn.Click += new System.EventHandler(this.dateCheck_bn_Click);
            // 
            // AirportForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 718);
            this.Controls.Add(this.dateCheck_bn);
            this.Controls.Add(this.dateCheck_tb);
            this.Controls.Add(this.open_ts);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.SerializeSortResult);
            this.Controls.Add(this.sort_listView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.sort_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_comboBox);
            this.Controls.Add(this.search_listView);
            this.Controls.Add(this.sort_listBox);
            this.Controls.Add(this.sort_label);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.RefreshOwners_button);
            this.Controls.Add(this.AddOwner_button);
            this.Controls.Add(this.Owner_label);
            this.Controls.Add(this.Owner_CLB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Crew_CLB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Air_listView);
            this.Controls.Add(this.Deserialize_button);
            this.Controls.Add(this.Serialize_button);
            this.Controls.Add(this.YearOfCreate_label);
            this.Controls.Add(this.Desc_textBox);
            this.Controls.Add(this.Description_label);
            this.Controls.Add(this.BuisnessClass_checkBox);
            this.Controls.Add(this.CheckSet_label);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.DateLastTS_label);
            this.Controls.Add(this.LastTS_dateTimePicker);
            this.Controls.Add(this.CountOfT_label);
            this.Controls.Add(this.LoadCapacity_label);
            this.Controls.Add(this.LoadCapacity_trackBar);
            this.Controls.Add(this.Date_listBox);
            this.Controls.Add(this.CountOfPeople_label);
            this.Controls.Add(this.PassCapacity_label);
            this.Controls.Add(this.Pass_trackBar);
            this.Controls.Add(this.Crew_label);
            this.Controls.Add(this.Model_label);
            this.Controls.Add(this.Model_comboBox);
            this.Controls.Add(this.Type_label);
            this.Controls.Add(this.Type_comboBox);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.ID_textBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximumSize = new System.Drawing.Size(1130, 765);
            this.MinimumSize = new System.Drawing.Size(1130, 765);
            this.Name = "AirportForm";
            this.Text = "  ";
            ((System.ComponentModel.ISupportInitialize)(this.Pass_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadCapacity_trackBar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.ComboBox Type_comboBox;
        private System.Windows.Forms.Label Type_label;
        private System.Windows.Forms.Label Model_label;
        private System.Windows.Forms.ComboBox Model_comboBox;
        private System.Windows.Forms.Label Crew_label;
        private System.Windows.Forms.TrackBar Pass_trackBar;
        private System.Windows.Forms.Label PassCapacity_label;
        private System.Windows.Forms.Label CountOfPeople_label;
        private System.Windows.Forms.ListBox Date_listBox;
        private System.Windows.Forms.TrackBar LoadCapacity_trackBar;
        private System.Windows.Forms.Label LoadCapacity_label;
        private System.Windows.Forms.Label CountOfT_label;
        private System.Windows.Forms.DateTimePicker LastTS_dateTimePicker;
        private System.Windows.Forms.Label DateLastTS_label;
        private System.Windows.Forms.Label CheckSet_label;
        private System.Windows.Forms.CheckBox BuisnessClass_checkBox;
        private System.Windows.Forms.Label Description_label;
        private System.Windows.Forms.TextBox Desc_textBox;
        private System.Windows.Forms.Label YearOfCreate_label;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Serialize_button;
        private System.Windows.Forms.Button Deserialize_button;
        private System.Windows.Forms.ListView Air_listView;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.CheckedListBox Crew_CLB;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.CheckedListBox Owner_CLB;
        private System.Windows.Forms.Label Owner_label;
        private System.Windows.Forms.Button AddOwner_button;
        private System.Windows.Forms.Button RefreshOwners_button;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.Label sort_label;
        private System.Windows.Forms.ComboBox sort_listBox;
        private System.Windows.Forms.ListView search_listView;
        private System.Windows.Forms.ComboBox search_comboBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button sort_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView sort_listView;
        private System.Windows.Forms.Button SerializeSortResult;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Button open_ts;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox dateCheck_tb;
        private System.Windows.Forms.Button dateCheck_bn;
    }
}

