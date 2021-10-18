using System;
using System.Collections.Generic;

namespace HW4
{
    class Program
    {
        // 2.Дана коллекция List<T>, требуется подсчитать,
        // сколько раз каждый элемент встречается в данной коллекции:
        // а) для целых чисел;
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 3, 4, 5, 6, 7, 6, 5, 4, 3, 4, 5, 6, 5 };
            Dictionary<int, int> pairs = new Dictionary<int, int>();

            foreach (var i in list)
            {
                foreach (var j in pairs)
                {
                    if (i != j.Key)
                    {
                        j.Key = i;
                    }

                    if (i == j.Key)
                    {
                        
                    }
                }
            }
        }
    }
}
