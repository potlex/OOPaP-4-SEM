using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Lab_2
{
    public class IDAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                int ID = (int)value;
                if (ID / 10000 != 1)
                    return true;
                else
                    this.ErrorMessage = "ID не должен начинаться с единицы!";
            }
            return false;
        }
    }
}
