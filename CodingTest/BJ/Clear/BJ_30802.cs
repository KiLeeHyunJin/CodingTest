using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    internal class BJ_30802
    {
        //https://www.acmicpc.net/problem/30802
        public void Main()
        {
            int playerCount = int.Parse(Console.ReadLine());

            string[] shirts = Console.ReadLine().Split(' ');
            string[] kitCount = Console.ReadLine().Split(' ');

            int shirtMultipleStandard   = int.Parse(kitCount[0]);
            int penMultipleStandard     = int.Parse(kitCount[1]);

            int shirtMultiple = 0;

            foreach (var item in shirts)
            {
                if (item == "0")
                    continue;

                int size = int.Parse(item);
                int count = size / shirtMultipleStandard;
                int and   = size % shirtMultipleStandard;

                if(and != 0)
                {
                    count++;
                }

                shirtMultiple += (int)count;
            }

            int penMultiple, penEa;
            if(penMultipleStandard == 0)
            {
                penEa = playerCount;
                penMultiple = 0;
            }
            else
            {
                penMultiple = playerCount / penMultipleStandard;
                penEa = playerCount % penMultipleStandard;
            }

            Console.WriteLine(shirtMultiple);
            Console.WriteLine(penMultiple + " " + penEa);
        }
    }
}
