using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    internal class BJ_1181
    {
        //https://www.acmicpc.net/problem/1181

        //시간초과
        public void Main()
        {

            int testCount = int.Parse(Console.ReadLine());
            List<string> strs = new List<string>(testCount);
            HashSet<string> hs = new(1000000);
            for (int i = 0; i < testCount; i++)
            {
                strs.Add(Console.ReadLine());
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < strs.Count(); i++)
            {
                if (hs.Contains(strs[i]))
                    continue;
                else
                {
                    for (int j = strs.Count() - 1; j > i; j--)
                    {
                        if (hs.Contains(strs[j]))
                            continue;

                        if (strs[i].Length > strs[j].Length)
                        {
                            string temp = strs[i];
                            strs[i] = strs[j];
                            strs[j] = temp;
                        }
                        else
                        {
                            for (int k = 0; k < strs[i].Length; k++)
                            {
                                if (strs[i][k] < strs[j][k])
                                {
                                    string temp = strs[i];
                                    strs[i] = strs[j];
                                    strs[j] = temp;
                                    break;
                                }
                            }
                        }
                    }
                }
                hs.Add(strs[i]);
                sb.Append($"{strs[i]} \n");
            }


            Console.WriteLine( sb.ToString() );
        }

    }
}
