using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    //https://www.acmicpc.net/problem/2292
    internal class BJ_2292
    {
        public void Main()
        {
            int moveCount = int.Parse(Console.ReadLine());
            int multipleCount = 0;
            while(moveCount > 1)
            {
                multipleCount++;
                moveCount -= multipleCount * 6;
            }
            multipleCount++;
            Console.WriteLine(multipleCount);

        }
    }
}
