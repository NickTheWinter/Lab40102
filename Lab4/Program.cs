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
            Console.WriteLine("\nОтвет: {0}\n", answer);
            //Console.WriteLine("sinx: {0}\n cosx: {1}\n log5x:\nLog10x:{4} {2}\nPow: {3}",Sin(x),Cos(x),Log(x,5), Pow(Sin(x *= Math.PI / 180) + Cos(x) + Cos(x), 2),Log(x,10));

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
        public static double Sin5Equal1() => 1;
        public static double Cos5Equal2() => 2;
        public static double GetAnswerXLowerOrEqualZeroWithoutSinCos() => Pow(Sin5Equal1() + Cos5Equal2() + Cos5Equal2(), 2);
        public static double Log5_5_Equal3() => 3;
        public static double Log10_5_Equal4() => 4;
        public static double GetAnswerXBiggerZeroWithoutLog() => Log10_5_Equal4() * Log5_5_Equal3();
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
