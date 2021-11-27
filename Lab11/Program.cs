using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Разработаем структуру для решения линейного уравнения 0 = kx + b.");
            linearEquation linearEquation;
            Console.Write("Введите коэффициент уравнения k: ");
            linearEquation.k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент уравнения b: ");
            linearEquation.b = Convert.ToDouble(Console.ReadLine());
            double decision = linearEquation.Root();
            Console.Write("Решение уравнения: x = {0}", decision);
            Console.ReadKey();
        }
        struct linearEquation
        {
            public double k;
            public double b;
            public double Root()
            {
                double x = Math.Round(- b / k, 2);
                return x;
            }
        }
    }
}
