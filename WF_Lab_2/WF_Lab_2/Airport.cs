using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace WF_Lab_2
{
    [Serializable]
    public class Airport
    {
        [NonSerialized]
        public List<Airport> airList = new List<Airport>();
        public enum TypeAir
        {
            пассажирский,
            грузовой,
            военный
        }
        public enum ModelAir
        {
            Airbus,
            Boeing,
            Heinkel,
            СУ,
            АН,
            ТУ
        }

        [XmlElement("Airport")]
        [ID]
        [RegularExpression(@"[0-9]{5}", ErrorMessage = "Неверный формат")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Отсуствует тип")]
        public TypeAir Type { get; set; }
        [Required(ErrorMessage = "Отсуствует модель")]
        public ModelAir Model { get; set; }
        [Required(ErrorMessage = "Отсуствует экипаж"), MinLength(1)]
        public string Crew { get; set; }
        [Required(ErrorMessage = "Вместимость не указана")]
        [Range (10, 360, ErrorMessage = "Вместимость неверна")]
        public int PassCapacity { get; set; }
        [Required(ErrorMessage = "Отсуствует дата")]
        [Range (1980, 2023, ErrorMessage = "Неверный год")]
        public int YearOfCreate { get; set; }
        [Required(ErrorMessage = "Вместимость не указана")]
        [Range (18, 120, ErrorMessage = "Вместимость неверна")]
        public int LoadCapacity { get; set; }
        [Required(ErrorMessage = "Отсуствует дата")]
        [RegularExpression("{0:d/M/yyyy HH:mm:ss}",
    ErrorMessage = "Wrong Syntax")]
        public DateTime LastTS { get; set; }
        public bool FullSet { get; set; }
        public string OtherDesc { get; set; }
        [Required(ErrorMessage = "Отсуствует создатель")]
        public string Owner { get; set; }
        public Airport() { }
        public Airport(int id, int type, int model, string crew, int passCapacity,
            int yearOfCreate, int loadCapacity, DateTime lastTS, bool fullSet, string otherDesc, string owner) 
        {
            ID = id;
            Type = (TypeAir)type;
            Model = (ModelAir)model;
            Crew = crew;
            PassCapacity = passCapacity;
            YearOfCreate = yearOfCreate;
            LoadCapacity = loadCapacity;
            LastTS = lastTS;
            FullSet = fullSet;
            OtherDesc = otherDesc;
            Owner = owner;
        }
        public override string ToString() 
        {
            return ID + " " + Type + " " + Model + " " + Crew + " " + PassCapacity 
                   + " " + LoadCapacity + " " + LastTS + " " + FullSet + " " + OtherDesc
                   + " " + Owner;
        }
    }
}
