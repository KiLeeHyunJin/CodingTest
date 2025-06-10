using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    internal class BJ_1966
    {
        public void Main()
        {
            int testCount = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int[] indexs = new int[10];
            for (int i = 0; i < testCount; i++)
            {
                int printCount, markIndex;
                {
                    string[] strs = Console.ReadLine().Split(' ');
                    printCount = int.Parse(strs[0]);
                    markIndex = int.Parse(strs[1]);
                }
                Queue<KeyValuePair<int,bool>> queInt = new Queue<KeyValuePair<int, bool>>(printCount);
                string[] strNums = Console.ReadLine().Split(' ');
                for (int j = 0; j < printCount; j++)
                {
                    int getNum = int.Parse(strNums[j]);
                    KeyValuePair<int, bool> kvPair = new(getNum, j == markIndex);
                    queInt.Enqueue(kvPair);
                    indexs[getNum]++;
                }

                int count = 0;

                while(queInt.Count != 0)
                {
                    KeyValuePair<int, bool> peek = queInt.Dequeue();
                    bool notDeQue = false;
                    for (int j = peek.Key + 1; j < 10; j++)
                    {
                        if (j < 10 &&indexs[j] != 0)
                        {
                            queInt.Enqueue(peek);
                            notDeQue = true;
                            break;
                        }
                    }
                    if(notDeQue == false)
                    {
                        count++;
                        indexs[peek.Key]--;
                        if (peek.Value)
                        {
                            sb.AppendLine($"{count}");
                            break;
                        }
                    }
                }
                for (int j   = 0; j < 10; j++)
                {
                    indexs[j] = 0;
                }
            }
          

            Console.WriteLine(sb.ToString());

        }
    }
}
