using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twice_Counter
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] list = { "Tom", "Jerry", "Tom", "Thomas", "Jerry", "Courage", "Tom", "Courage" };
            int twiceResult = TwiceCounter(list);
            Console.WriteLine(twiceResult);
            Console.ReadLine();
        }
        static int TwiceCounter(string[] strings)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            int count = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                if (map.ContainsKey(strings[i]))
                {
                    map[strings[i]]++;
                }
                else
                {
                    map.Add(strings[i], 1);
                }
            }

            foreach (var author in map)
            {
                if (author.Value == 2)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
