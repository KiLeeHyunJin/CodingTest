using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    internal class BJ_1676
    {
        static int[] arry = { 0, 0 };

        public void Main()
        {
            //첫째 줄에 N이 주어진다. (0 ≤ N ≤ 500)
            int n = int.Parse(Console.ReadLine());

            ulong result = Factorial(n);
            Console.WriteLine(result);

            int count = 
                arry[0] > arry[1] ? //if
                arry[1] :// true
                arry[0]; // else 

            Console.WriteLine(count);
        }


        public ulong Factorial(int count)
        {
            if (count < 1) //재귀 탈출 조건
                return 1;

            int tmp = count;

            while(true)
            {
                if (tmp % 5 == 0)
                {
                    int sour = tmp / 5;
                    if (sour != 0)
                    {
                        arry[1]++;
                        tmp = sour;
                    }
                }
                
                else if (tmp % 2 == 0)
                {
                    int sour = tmp / 2;
                    if (sour != 0)
                    {
                        arry[0]++;
                        tmp = sour;
                    }
                }

                else //무한 루프 탈출 조건
                {
                    break;
                }

            }


            return (ulong)count * Factorial(count - 1);
        }
    }
}
