using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    //https://www.acmicpc.net/problem/11723

    internal class BJ_11723
    {
        public void Main()
        {
            StringBuilder sb = new StringBuilder();
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[21];
            for (int i = 0; i < count; i++)
            {
                string[] strs = Console.ReadLine().Split(' ');
                if(strs.Length == 2)
                {
                    int input = int.Parse(strs[1]);
                    switch (strs[0])
                    {
                        case "add":
                            array[input] = input;
                            break;
                        case "remove":
                            array[input] = 0;
                            break; 
                        case "check":
                            if (array[input] != 0)
                                sb.Append("1 \n");
                            else
                                sb.Append("0 \n");
                             break;
                        case "toggle":
                            if (array[input] != 0)
                            {
                                array[input] = 0;
                            }
                            else
                            {
                                array[input] = input;
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    if (strs[0] == "empty")
                    {
                        for (int j = 0; j < 21; j++)
                        {
                            array[j] = 0;
                        }
                    }
                    else // all
                    {
                        for (int j = 0; j < 21; j++)
                        {
                            array[j] = j+1;
                        }
                    }
                }


            }
            Console.WriteLine(sb.ToString());
        }
    }
}
