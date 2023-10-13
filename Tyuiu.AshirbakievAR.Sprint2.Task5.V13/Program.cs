using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AshirbakievAR.Sprint2.Task5.V13.Lib;

namespace Tyuiu.AshirbakievAR.Sprint2.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Аширбакиев А. Р. | СмартБ 23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Аширбакиев Алмаз Ринатович | СмартБ 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch                  *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение номер года: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение номер месяца: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение номер дня: ");
            int day = Convert.ToInt32(Console.ReadLine());

            string res = Convert.ToString(ds.FindDateOfNextDay(year, month, day));
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res != "0")
            {
                res = res.Substring(0, res.Length - 4) + "." + res.Substring(res.Length - 4, 2) + "." + res.Substring(res.Length - 2, 2);
                Console.WriteLine($"Дата следующего дня - {res}");
            }
            else
            {
                res = "такой даты не существует";
                Console.WriteLine(res);
            }


            Console.ReadKey();
        }
    }
}
