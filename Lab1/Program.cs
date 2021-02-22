using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        /// <summary>
        /// Вычисляет сумму вклада y
        /// </summary>
        /// <param name="p">Первая цифра варианта</param>
        /// <param name="q">Вторая цифра варианта</param>
        /// <returns>Сумма вклада y</returns>
        static void CalculateOne(int p, int q)
        {
            int z0 = 100 + 4*p + 3*q + 1;
            int i = p + q + 1;
            double r = 0.01 * i;
            double y;
            int t = 0;
            Console.WriteLine("Первый случай");
            do
            {
                y = z0 * Math.Pow(1 + r, t);
                Console.WriteLine("{0,1} {1,8:f2}", t, y);
                t++;
            }
            while (y < 2 * z0);
            Console.WriteLine("Время, за которое вклад удвоится : {0,1}", t - 1);
            Console.WriteLine("Начальный вклад: {0,8:f2}", z0);
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
        }

        static void CalculateTwo(int p, int q)
        {
            int z0 = 100 + 4 * p + 3 * q + 1;
            double z = 100 + 4 * p + 3 * q + 1;
            int i = p + q + 1;
            double r = 0.01 * i;
            double y;
            int t = 1;
            Console.WriteLine("Второй случай");
            Console.WriteLine("Год\tСредства");
            do
            {
                y = (z/r)*(1+(1/(10*r)))*Math.Pow((1+r),(t+1))-((z*t)/(10*r))-(z/(10*r*r))*(1+11*r);
                Console.WriteLine("  {0,1}\t{1,8:f2}", t, y);
                t++;
            }
            while (y < 5 * z0);
            Console.WriteLine("Время, за которое сумма вклада вырастет в 5 раз : {0,1}", t - 1);
            Console.WriteLine("Начальный вклад: {0,8:f2}", z0);
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
        }


        static void CalculateThree(int p, int q)
        {
            int i = p + q + 1;
            double r = 0.01 * i;
            double y5 = 10 * (100 + 4 * p + 3 * q + 1);
            int t = 5;
            Console.WriteLine("Дополнительный расчет");
            Console.WriteLine($"Планируемая сумма через 5 лет: {y5}");
            double z0 = y5 * 1/(((1/r)*(1+(1/(10*r)))*Math.Pow((1+r),5+1) - (5/(10*r)) - (1/(10*r*r))*(1+11*r)));
            Console.WriteLine($"Коэффицент: {y5/z0}");
            Console.WriteLine("Начальный вклад: {0,8:f2}", z0);
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1.");
            Console.WriteLine("Моделирование изменения денежных средств на вкладе");
            Console.WriteLine("Ваганов А.П.");
            Console.WriteLine("----------------------------------------------------");
            CalculateOne(0, 0);
            CalculateTwo(0, 0);
            CalculateThree(0, 0);
        }
    }
}
