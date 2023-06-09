using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace WPF_Lab_4_5.classes
{
    public static class Serialize
    {
        public static void DataSerialize(Company company)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Company));

            using (FileStream fs = new FileStream("D:\\ООПиП 2s\\WPF_Lab_4-6\\WPF_Lab_4-5\\Tours.xml", FileMode.Create))
            {
                serializer.Serialize(fs, company);
            }
        }
        public static Company DataDeserialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Company));

            Company company = null;
            using (FileStream fs = new FileStream("D:\\ООПиП 2s\\WPF_Lab_4-6\\WPF_Lab_4-5\\Tours.xml", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    company = serializer.Deserialize(fs) as Company;
                }
            }

            return company;
        }

        public static void DataSerializeUR(Company company)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Company));

            using (FileStream fs = new FileStream("D:\\ООПиП 2s\\WPF_Lab_4-6\\WPF_Lab_4-5\\ToursUR.xml", FileMode.Create))
            {
                serializer.Serialize(fs, company);
            }
        }
        public static Company DataDeserializeUR()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Company));

            Company company = null;
            using (FileStream fs = new FileStream("D:\\ООПиП 2s\\WPF_Lab_4-6\\WPF_Lab_4-5\\ToursUR.xml", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    company = serializer.Deserialize(fs) as Company;
                }
            }

            return company;
        }
    }
}
