using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program

    {
        /// Перечисление для задания 4
        enum DayWeek
        {
            Понедельник = 1,
            Вторник = 2,
            Среда = 3,
            Четверг = 4,
            Пятница = 5,
            Суббота = 6,
            Воскресенье = 7
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            ///Проверить упорядочен ли массив по возрастанию. Если нет, необходимо вывести элемент, на котором последовательность прекращает возрастать.
            int[] arr = new int[10];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(101);
                Console.WriteLine(arr[i]);
            }


            bool up = true;
            int index = -1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int m = arr[i];
                int n = arr[i + 1];

                if (m > n)
                {
                    up = false;
                    index = i + 1;
                    break;
                }
            }

            if (up)
            {
                Console.WriteLine("Числа в массиве упорядочены по возрастанию");
            }
            else
            {
                Console.WriteLine($" Последовательность перестает возрастать на элементе {arr[index]}.");
            }

            Console.WriteLine("Задание 2");
            ///Программа присваивает введенному значению название карты.
            Console.WriteLine("Введите число от 6 до 14");
            try
            {
                int karta;
                int.TryParse(Console.ReadLine(), out karta);
                if (karta < 15 && karta > 5)

                {
                    switch (karta)
                    {
                        case 6:
                            Console.WriteLine("6");
                            break;
                        case 7:
                            Console.WriteLine("7");
                            break;
                        case 8:
                            Console.WriteLine("8");
                            break;
                        case 9:
                            Console.WriteLine("9");
                            break;
                        case 10:
                            Console.WriteLine("10");
                            break;
                        case 11:
                            Console.WriteLine("Валет");
                            break;
                        case 12:
                            Console.WriteLine("Дама");
                            break;
                        case 13:
                            Console.WriteLine("Король");
                            break;
                        case 14:
                            Console.WriteLine("Туз");
                            break;






                    }


                }
                else
                {
                    Console.WriteLine("Вы ввели число, находящееся вне диапозона от 6 до 14!");


                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели нечисловое значение");
            }
            finally
            {
                Console.WriteLine("Программа завершена");
            }
            Console.WriteLine("Задание 4");
            /// Программа присваивает введенному числу день недели
            Console.WriteLine("Введите число от 1 до 7");
            try
            {
                int day;
                int.TryParse(Console.ReadLine(), out day);
                if (day < 8 && day > 0)
                {
                    DayWeek dayWeek = (DayWeek)day;
                    Console.WriteLine($"День недели с номером {day} - это {dayWeek}");
                }
                else
                {
                    Console.WriteLine("Число находится вне заданного диапазона");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели нечисловое значение!");

            }
            finally
            {
                Console.WriteLine("Программа завершена");
            }

            Console.WriteLine("Задание 5");
            ///Программа считает количество кукол и hello kitty и выводит количество кукол.
            string[] array = { "Hello Kitty", "Barbie doll", "Lego", "Teddy bear", "Barbie doll" };
            int dollsCount = 0;

            foreach (string item in array)
            {
                if (item == "Hello Kitty" || item == "Barbie doll")
                {
                    dollsCount++;
                }
            }

            Console.WriteLine("Количество кукол в сумке: " + dollsCount);


            Console.ReadKey();
        }
    }
}
