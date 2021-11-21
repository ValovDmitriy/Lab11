using System;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            double k, b;
            k = 0;
            b = 0;
            Console.WriteLine("Решение уравнения 0=kx+b");
            try
            {
                Console.Write("Введите k:");
                k = Convert.ToDouble(Console.ReadLine());
                if (k==0)
                {
                    Console.WriteLine("k вне области определения");
                    System.Environment.Exit(0);
                }
                Console.Write("Введите b:");
                b = Convert.ToDouble(Console.ReadLine());
                if (b == 0)
                {
                    Console.WriteLine("x=0");
                    System.Environment.Exit(0);
                }
                Console.Write("x=");
            }
            catch (Exception)
            {
                Console.WriteLine("Некорректно введены данные");
                System.Environment.Exit(0);
            }
            LinearEquation linearEquation1 = new LinearEquation { factorB = b, factorK = k };
            linearEquation1.Root();
        }
        struct LinearEquation
        {
            public double factorK;
            public double factorB;
            private double variableX;
            public void Root()
            {
                variableX = Math.Round(-factorB / factorK, 3);
                Console.WriteLine(variableX);
            }
        }
        
    }
}
