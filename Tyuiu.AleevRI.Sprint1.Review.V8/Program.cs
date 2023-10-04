using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AleevRI.Sprint1.Review.V8.Lib;

namespace Tyuiu.AleevRI.Sprint1.Review.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Алеев Р. И. | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: SprintReview                                                   *");
            Console.WriteLine("* Задание #                                                            *");
            Console.WriteLine("* Вариант #8                                                           *");
            Console.WriteLine("* Выполнил: Алеев Руслан Ильнурович | АСОиУБ-23-1                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("*                      y                                               *");
            Console.WriteLine("* z =  x * ln (x) + ------------                                       *");
            Console.WriteLine("*                   cos (x) - x                                        *");
            Console.WriteLine("*                            ---                                       *");
            Console.WriteLine("*                             3                                        *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("z = " + ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
