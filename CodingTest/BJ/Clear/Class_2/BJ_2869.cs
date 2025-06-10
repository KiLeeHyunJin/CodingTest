using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    internal class BJ_2869
    {
             
        public void Main()
        {
            const int count = 3;
            int[] iArray = new int[count];
            int clime, slide, height, baseClime;
            {
                string[] strs = Console.ReadLine().Split(" ");

                clime = int.Parse(strs[0]);
                slide = int.Parse(strs[1]);
                height = int.Parse(strs[2]);
                baseClime = clime - slide;
            }

            if(height < clime)
            {
                Console.WriteLine(1);
                return;
            }

            int lenth = height - clime;
            int other = lenth % baseClime;
            int day = ((height - clime) / baseClime) + 1;
            if (other != 0)
            {
                day += 1;
            }

            Console.WriteLine(day);
        }
    }
}
