using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO2022.CSharp.Forms.Lab06.Ex1.WinGrafSinLine
{
    class Operation
    {
        public static double SummSin(int x, double a, double b)
        {
            double res;
            return res = Math.Sin(x * a) + Math.Sin(x * b);
        }
    }
}
