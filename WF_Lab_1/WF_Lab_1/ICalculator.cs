using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Lab_1
{
    public interface ICalculator
    {
        bool SetVarA(int varA);
        bool SetVarB(int varB);
        int Sum(int varA, int varB);
        int Difference(int varA, int varB);
        int Multiplication(int varA, int varB);
        double Division(int varA, int varB);
        double Whole(int varA, int varB);
        double Fraction(int varA, int varB);
        bool Buf(double varC);
        double? GetVar();
        void Clear(double? buf);
    }
}
