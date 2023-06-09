using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_Lab_1
{
    public class Calculator : ICalculator
    {
        private int VarA;
        private int VarB;
        private double VarC;
        public double? VarCP { get; set; }
        private int VarResult;
        private int VarDiv;
        private double VarDResult;

        public bool SetVarA(int varA) 
        {
            try
            {
                VarA = Convert.ToInt32(varA);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректное число");
                return false;
            }
        }
        public bool SetVarB(int varB)
        {
            try
            {
                VarB = Convert.ToInt32(varB);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректное число");
                return false;
            }
        }
        public int Sum(int VarA, int VarB) 
        {
            try
            {
                VarResult = VarA + VarB;
                return VarResult;
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные");
                return 0;
            }
        }
        public int Difference(int VarA, int VarB)
        {
            try
            {
                VarResult = VarA - VarB;
                return VarResult;
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные");
                return 0;
            }
        }
        public int Multiplication(int VarA, int VarB)
        {
            try
            {
                VarResult = VarA * VarB;
                return VarResult;
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные");
                return 0;
            }
        }
        public double Division(int VarA, int VarB)
        {
            try
            {
                if (VarB != 0)
                {
                    VarResult = VarA / VarB;
                    return VarResult;
                }
                else throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные");
                return 0;
            }
        }
        public double Whole(int VarA, int VarB)
        {
            try
            {
                VarDResult = VarA / VarB;
                VarDResult = Math.Truncate(VarDResult);
                return VarDResult;
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные");
                return 0;
            }
        }
        public double Fraction(int VarA, int VarB)
        {
            try
            {
                VarDiv = Math.DivRem(VarA, VarB, out VarResult);
                return VarResult;
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные");
                return 0;
            }
        }
        public bool Buf(double varC)
        {
            try
            {
                VarCP = varC;
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные");
                return false;
            }
        }
        public double? GetVar()
        {
            try 
            {
                if (VarCP != null)
                    return VarCP;
                else return null;
            }
            catch (Exception) 
            {
                MessageBox.Show("Буфер пуст");
                return 0;
            }
        }
        public void Clear(double? buf) 
        {
            buf = null; 
            VarCP = null;
        }
    }
}
