using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;

namespace WPF_Lab_4_5.classes
{
    [Serializable]
    public class Company
    {
        [XmlArray("Tours"), XmlArrayItem("Tour")]
        public List<Tour> tourList;

        public Company() 
        {
            tourList = new List<Tour>(); 
        }
        public Company(Company _comp) : this()
        { 
            foreach(Tour tour in _comp.tourList)
            {
                tourList.Add(tour);
            }
        }

        public void Add(Tour tour) => tourList.Add(tour);

    }
}
