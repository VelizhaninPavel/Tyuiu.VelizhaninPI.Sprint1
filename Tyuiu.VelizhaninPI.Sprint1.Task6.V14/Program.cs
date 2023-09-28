using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VelizhaninPI.Sprint1.Task6.V14.Lib;
using Tyuiu.VelizhaninPI.Sprint1.Task6.V14.Test;

namespace Tyuiu.VelizhaninPI.Sprint1.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Велижанин П. И. | ИИПб-23-3 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Велижанин Павел Ильич | ИИПб-23-3                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Пользователь вводит текст. Проверить, что строка составлена             *");
            Console.WriteLine("* только из строчных русских букв.                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите текст:");
            string str = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            if (ds.CheckLowerCaseRusLetters(str) == true)
            {
                Console.WriteLine("Cтрока составлена только из строчных русских букв.");
            }
            if (ds.CheckLowerCaseRusLetters(str) == false)
            {
                Console.WriteLine("Cтрока составлена не только из строчных русских букв.");
            }
            Console.ReadLine();
        }
    }
}
