using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Lab_2
{
    public class Crew
    {
        public enum Professions 
        {
            пилот,
            стюардесса
        }
        [Required(ErrorMessage = "Отсуствует ID")]
        [StringLength(45, MinimumLength = 18, ErrorMessage = "Недопустимая длина имени")]
        public string FIO { get; set; }
        [Required(ErrorMessage = "Отсуствует профессия")]
        public Professions Profession { get; set; }
        [Required(ErrorMessage = "Отсуствует возраст")]
        [RegularExpression(@"[0-9]{2}", ErrorMessage = "Неверный формат")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Отсуствует стаж")]
        public int Exp { get; set; }
        public Crew() { }
        public Crew(string fio, int profession, int age, int exp) 
        {
            FIO = fio;
            Profession = (Professions)profession;
            Age = age;
            Exp = exp;
        }
    }
}
