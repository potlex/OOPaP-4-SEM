using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Media.Imaging;

namespace WPF_Lab_4_5
{
    [Serializable]
    [XmlRoot("Tour")]
    public class Tour
    {
        private string name;
        public string Name { get; set; }
        private int price;
        public int Price { get; set; }
        private string counrty;
        public string Counrty { get; set; }
        private int time;
        public int Time { get; set; }
        private string type;
        public string Type { get; set; }
        private int rating;
        public int Rating { get; set; }
        private string image;
        public string Image { get; set; }
        private string description;
        public string Description { get; set; }

        public Tour() { }
        public Tour(string name, int price, string counrty, int time, string type, 
            int rating, string image, string description)
        {
            Name = name;
            Price = price;
            Counrty = counrty;
            Time = time;
            Type = type;
            Rating = rating;
            Image = image;
            Description = description;
        }
        
        public Tour(Tour _t)
        {
            Name = _t.Name;
            Price = _t.Price;
            Counrty = _t.Counrty;
            Time = _t.Time;
            Type = _t.Type;
            Rating = _t.Rating;
            Image = _t.Image;
            Description = _t.Description;
        }
    }
}
