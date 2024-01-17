using System;
using System.Collections.Generic;


namespace HashSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            while (true)
            {
                Console.Write("Введите число: ");
                string str = Console.ReadLine();
                if (str == "")
                {
                    break;
                }
                if (!int.TryParse(str, out int number)) 
                {
                    Console.WriteLine("Введено некоректное число");
                    continue;
                }
                else
                {
                    if (set.Contains(number))
                    {
                        Console.WriteLine("Это число уже вводилось");
                    }
                    else
                    {
                        Console.WriteLine("Число сохранено");
                    }
                    set.Add(number);
                }
            }
            Console.WriteLine("Сохраненные числа:");
            foreach (int i in set)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
    }
}
