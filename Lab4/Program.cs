using System;
using static Lab4.MathCalc;

namespace Lab4
{
    public class Program
    {
        static void Main(string[] args)
        {
            InitProgram();
            Console.ReadLine();
        }
        static void InitProgram()
        {
            double answer = 0;
            double x = EnterNumber();

            if (x <= 0)
            {
                answer = GetAnswerXLowerOrEqualZero(x);
            }
            else
            {
                answer = GetAnswerXBiggerZero(x);
            }
            Console.WriteLine("\nОтвет: {0}", answer);

        }
        //public static double GetAnswerXLowerOrEqualZeroEqual4(double x) => 4;
        //public static double GetAnswerXBiggerZeroEqual0(double x) => 0;
        public static double EnterNumber()
        {
            Console.Clear();
            Console.WriteLine("Введите X:");
            double x = 0;
            try
            {

                x = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                EnterNumber();
            }
            return x;
        }
        public static double GetAnswerXLowerOrEqualZero(double x)
        {
            return Pow(Sin(x *= Math.PI / 180) + Cos(x) + Cos(x), 2);
        }
        public static double GetAnswerXBiggerZero(double x)
        {
            return Log(x, 10) * Log(x, 5);
        }
    }

}
