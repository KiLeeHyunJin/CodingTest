using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    internal class BJ_1654
    {
        public void Main()
        {
            ulong lanCount, needCount;
            {
                string[] strs = Console.ReadLine().Split(' ');
                lanCount = ulong.Parse(strs[0]);
                needCount = ulong.Parse(strs[1]);
            }
            Dictionary<ulong, ulong> memorial = new Dictionary<ulong, ulong>();   
            List<ulong> lans = new List<ulong>(10000);
            ulong totalLength = 0;
            for (ulong i = 0; i < lanCount; i++)
            {
                ulong lanLength = ulong.Parse(Console.ReadLine());
                totalLength += lanLength;
                lans.Add(lanLength);
            }
            ulong result = totalLength / (ulong)needCount;
            ulong count = 0;

            while (true)
            {
                count = 0;
                for (int i = 0; i < (int)lanCount; i++)
                {
                    count += lans[i] / result;
                }

                if(count == needCount)
                {
                    break;
                }
                else if(count < needCount) //양이 부족하다 (개수를 늘리려는 시도 중)
                {
                    memorial.Add(result, count);
                    result -= 2;

                    if (memorial.ContainsKey(result))
                    {
                        result -= 1;

                        if (memorial.ContainsKey(result))
                        {
                            if (memorial[result] > needCount)
                            {
                                break;
                            }
                        }
                    }
                }

                else //양이 충분하다 (개수를 줄이려는 시도 중)
                {
                    memorial.Add(result, count);
                    result += 2;
                    if (memorial.ContainsKey(result)) 
                    {
                        result += 1;

                        if (memorial.ContainsKey(result))
                        {
                            if (memorial[result] < needCount)
                            {
                                break;
                            }
                        }
                       
                    }
                }
            }
            Console.WriteLine(result); 
        }
    }
}
