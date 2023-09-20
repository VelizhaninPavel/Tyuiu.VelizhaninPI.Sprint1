using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VelizhaninPI.Sprint1.Task1.V14.Lib;
using Tyuiu.VelizhaninPI.Sprint1.Task1.V14.Test;

namespace Tyuiu.VelizhaninPI.Sprint1.Task1.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Велижанин П. И. | ИИПб-23-3 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Велижанин Павел Ильич | ИИПб-23-3                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле a*b/c+(a/(b+c)) и                        *");
            Console.WriteLine("* печатает его на экране.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* a*b/c+(a/(b+c))                                                         *");

            double a, b, c;

            Console.WriteLine("Введите зачение a:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите зачение b:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите зачение c:");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(a, b, c));
            Console.ReadLine();

        }
    }
}
