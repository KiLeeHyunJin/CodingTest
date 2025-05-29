using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    internal class BJ_1978
    {
        //https://www.acmicpc.net/problem/1978
        public void Main()
        {
            int testCase = int.Parse(Console.ReadLine());

            string[] strs = Console.ReadLine().Split(' ');
            List<int> list = new List<int>(strs.Length);
            for (int i = 0; i < list.Count(); i++)
            {
                list.Add(int.Parse(strs[i]));
            }

            int result = 0;
            foreach (var item in list)
            {
                if(item <= 1)
                {
                    continue;
                }
                bool isSosu = true;
                for (int i = 2; item > i; i++)
                {
                    int div = item % i;
                    if((div) == 0)
                    {
                        isSosu = false;
                        break;
                    }
                }
                if(isSosu)
                {
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
