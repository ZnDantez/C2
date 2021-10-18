using System;
using System.Collections.Generic;

namespace HW4
{
    class Program
    {
        // 2. Дана коллекция List<T>, требуется подсчитать,
        // сколько раз каждый элемент встречается в данной коллекции:
        // а) для целых чисел;

        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 3, 4, 5, 6, 7, 6, 5, 4, 3, 4, 5, 6, 5 };
            Dictionary<int, int> pairs = new Dictionary<int, int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (pairs.ContainsKey(list[i]))
                    pairs[list[i]]++;
                else
                    pairs.Add(list[i], 1);
            }

            foreach(var i in pairs)
            {
                Console.WriteLine($"{i.Key} - {i.Value}");
            }
        }
    }
}
