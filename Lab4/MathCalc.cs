using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class MathCalc
    {
        public static double Sin(double x)
        {
            const double eps = 1e-15;
            double s = 0;
            double r = x;
            int n = 1;
            while (Math.Abs(r) > eps)
            {
                s = s + r;
                n = n + 2;
                r = -r * x * x / (n * (n - 1));
            }
            return s;
        }

        public static double Log(double num, double basee)
        {
            double start;
            double end = 0;
            double middle = 0;
            double accuracy = 5;

            while (Math.Pow(basee, end) <= num)
            {
                end += 1;
            }
            start = end - 1;
            if (Math.Pow(basee, start) == num)
            {
                return start;
            }
            for (int i = 0; i < accuracy * 4; i++)
            {
                middle = (start + end) / 2;

                if (Math.Pow(basee, middle) > num)
                {
                    end = middle;
                }
                if (Math.Pow(basee, middle) < num)
                {
                    start = middle;
                }
                if (Math.Pow(basee, middle) == num)
                {
                    return start;
                }
            }
            return middle;
        }
        public static double Cos(double x)
        {
            return Sin(Math.PI / 2 - x);
        }
        public static double Pow(double a, int b)
        {
            double powed = a;
            for (int i = 1; i <= b - 1; i++)
            {
                powed *= a;
            }
            return powed;
        }
    }
}
