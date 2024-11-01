using System;
using Tyuiu.DyakovMS.Sprint3.Task0.V22.Lib;
namespace Tyuiu.DyakovMS.Sprint3.Task0.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Оператор цикла for                                                      *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу используя цикл for, которая вычисляет произведение ряд*");
            Console.WriteLine("*да по формуле, при a=0,25                                                *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Переменная a = ");
            double value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Старт шага = ");
            int startValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Конец шага = ");
            int stopValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetMultiplySeries(value, startValue, stopValue);
            Console.WriteLine("Сумма ряда = " + result);
            Console.ReadKey();
        }
    }
}