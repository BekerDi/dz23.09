using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz23._09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int day;
            int.TryParse(Console.ReadLine(), out day);
            int x = day;
            

                int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                string[] monthNames = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            do
            {
                try { 

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
                
                







                    Console.WriteLine($"{day} соответствует {dayOfMonth} {monthNames[month - 1]}");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Вы ввели чило меньше 1 или больше 365");
                    break;

                }
            } while (day < 1 | day > 365);





        Console.WriteLine("Для перехода на следующее задание нажмите ENTER");
            Console.ReadKey();

            Console.WriteLine("Задание 4.2");
            Console.WriteLine("Введите число от 1 до 365");
             

            Console.ReadKey();






        }
    }
}
