using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AleevRI.Sprint1.Review.V8.Lib
{
    public class DataService : ISprint1Task7V8
    {
        public double Calculate(double x, double y)
        {
            double res = (x * Math.Log(x)) + y / (Math.Cos(x) - x / 3);
            return Math.Round(res, 3);
        }
    }
}
