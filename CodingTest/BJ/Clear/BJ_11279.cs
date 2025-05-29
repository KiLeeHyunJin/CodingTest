using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    internal class BJ_11279
    {
        //https://www.acmicpc.net/problem/11279

        public void Main()
        {
            StringBuilder sb = new StringBuilder();

            PriorityQueue<int, int> pq = new(100000);

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if(input == 0)
                {
                    if(pq.Count == 0)
                    {
                        sb.Append("0 \n");
                    }
                    else
                    {
                        sb.Append($"{pq.Dequeue()} \n");

                    }
                }
                else
                {
                    pq.Enqueue( input, input);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
