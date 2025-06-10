using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    internal class BJ_1764
    {
        public void Main()
        {
            string[] strs   = Console.ReadLine().Split(' ');
            int notListen   = int.Parse(strs[0]);
            int notSee      = int.Parse(strs[1]);
            HashSet<string> ntSet = new();

            for (int i = 0; i < notListen; i++)
            {
                ntSet.Add(Console.ReadLine()); 
            }

            List<string> sameName = new(500000);
            for (int i = 0; i < notSee; i++)
            {
                string name = Console.ReadLine();
                if(ntSet.Contains(name))
                {
                    sameName.Add(name);
                }
            }

            Console.WriteLine($"{sameName.Count()}");
            sameName.Sort();
            foreach (var item in sameName)
            {
                Console.WriteLine(item);
            }
        }

    }
}
