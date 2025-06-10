using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    internal class BJ_2839
    {
        public void Main()
        {
            int dest;
            {
                string str = Console.ReadLine();
                if(str == null)
                {
                    return;
                }
                dest = int.Parse(str);
            }

            int bigCount = 0;
            int smallCount = 0;

            int other = dest % 5;
            if(other == 0)
            {
                bigCount = dest / 5;
            }
            else
            {
                smallCount  = dest / 3;
                other       = dest % 3;

                do
                {
                    if (other == 0)
                    {
                        break;
                    }
                    else if (smallCount != 0)
                    {
                        smallCount--;
                        other += 3;
                        if (other >= 5)
                        {
                            other -= 5;
                            bigCount++;
                        }
                    }
                    else
                    {
                        break;
                    }

                }
                while (other != 0);

                if (other == 0)
                {
                    int temp = smallCount / 5;
                    if (temp != 0)
                    {
                        bigCount += temp * 3;
                        other = smallCount % 5;
                        smallCount -= temp * 5;
                    }
                }
            }

            {
                int temp = (bigCount * 5) + (smallCount * 3);
                if (temp != dest)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine(smallCount + bigCount);
                }

            }

        }
    }
}
