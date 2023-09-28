using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Программа считывает число от 1 до 365 ему соответсвующую дату. В случае, если пользователь вводит неверное число, программа зацикливается до тех пор, пока не будет введенно правильное значение. Также программа учитывает, год весокосный или нет.
            int day;
            int year;

            do
            {
                Console.WriteLine("Введите число от 1 до 366:");               
                int.TryParse(Console.ReadLine(), out day);
                Console.WriteLine("Введите год");
                int .TryParse(Console.ReadLine(), out year);

                if (day < 1 || day > 366)
                {
                    Console.WriteLine("Вы ввели число меньше 1 или больше 365");
                }
                else if (year % 4 == 0 && (year % 100 == 0 || year % 400 == 0) )
                {
                    int[] monthDays = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                    string[] monthNames = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "сентября", };
                    int month = 0;
                    int dayOfMonth = day;
                    for (int i = 0; i < monthDays.Length; i ++)
                    {
                        if (dayOfMonth <= monthDays[i])
                        {
                            month = i + 1;
                            break;

                        }
                        dayOfMonth -= monthDays[i];

                    }
                    Console.WriteLine($"{day} соответсвует {dayOfMonth} {monthNames[month - 1]} {year} года");
                }
                else
                {
                    int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                    string[] monthNames = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };

                    int month = 0;
                    int dayOfMonth = day;

                    for (int i = 0; i < monthDays.Length; i++)
                    {
                        if (dayOfMonth <= monthDays[i])
                        {
                            month = i + 1;
                            break;
                        }
                        dayOfMonth -= monthDays[i];
                    }

                    Console.WriteLine($"{day} соответствует {dayOfMonth} { monthNames[month - 1]} {year} года");
                    
                }
                
            } while (day < 1 || day > 366);
            Console.ReadKey();
        }
    }
}
