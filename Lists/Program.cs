using System;
using System.Collections.Generic;


namespace Lists
{
    internal class Program
    {
        
        /// <summary>
        /// Generates list of 100 integers between 0 and 100 
        /// </summary>
        /// <returns>Generated list</returns>
        private static List<int> GenerateList()
        {
            List<int> list = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                list.Add(rnd.Next(100));                
            }

            return list;
        }

        /// <summary>
        /// Prints list on screen
        /// </summary>
        /// <param name="list">List to print</param>
        /// <param name="message">Message to print before list</param>
        private static void ShowList(List<int> list, string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            
            foreach (int item in list)
            {
                Console.Write($"{item} | ");
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Deletes numbers between left border and right border from list
        /// </summary>
        /// <param name="list">List to filter</param>
        /// <param name="leftBorder">Left border</param>
        /// <param name="rightBorder">Right border</param>
        private static void FilterList(List<int> list, int leftBorder, int rightBorder)
        {
            int i = 0;
            
            while (i < list.Count)
            {
                if (list[i] > leftBorder && list[i] < rightBorder)
                {
                    // Console.WriteLine($"{i} item removed: {list[i]}");
                    list.RemoveAt(i);                    
                    continue;
                }
                i++;
            }
        }
        
        static void Main(string[] args)
        {
            List<int> list = GenerateList();
            ShowList(list, "Generated list:");
            FilterList(list, 25, 50);
            ShowList(list, "Filtered list: ");
            Console.ReadKey();
        }
    }
}
