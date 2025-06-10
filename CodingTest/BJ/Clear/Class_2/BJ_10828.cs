using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    internal class BJ_10828
    {

        public void Main()
        {
            int testCount = int.Parse(Console.ReadLine());
            List<int> ints = new List<int>(testCount);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < testCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ');


                switch (input[0])
                {
                    case "pop":
                        {
                            if (ints.Count != 0)
                            {
                                sb.Append($"{ints[ints.Count - 1]} \n");
                                ints.RemoveAt(ints.Count - 1);
                            }
                            else
                            {
                                sb.Append($"{-1} \n");
                            }
                        }
                        break;
                    case "push":
                        ints.Add(int.Parse(input[1]));
                        break;
                    case "empty":
                        {
                            int answord = ints.Count == 0 ? 1 : 0;
                            sb.Append($"{answord} \n");
                        }
                        break;
                    case "size":
                        sb.Append($"{ints.Count} \n");
                        break;
                    case "top":
                        {
                            if(ints.Count != 0)
                            {
                                sb.Append($"{ints[ints.Count - 1]} \n");
                                //ints.RemoveAt(ints.Count - 1);
                            }
                            else
                            {
                                sb.Append($"{-1} \n");
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine( sb.ToString() );
        }

    }
}
