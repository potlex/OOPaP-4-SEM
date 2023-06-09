using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Lab_4_5.classes
{
    public class Container
    {
        Stack<Company> companies;

        public Container() 
        {
            companies = new Stack<Company>();
        }

        public void Push(Company company) => companies.Push(new Company(company));
        public Company Pop()
        {
            return companies.Pop();
        }
        public void Clear() => companies.Clear();
        public int Count() 
        {
            return companies.Count;
        }
    }
}
