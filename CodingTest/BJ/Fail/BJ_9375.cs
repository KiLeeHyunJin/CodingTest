using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    public class BJ_9375
    {
        //https://www.acmicpc.net/problem/9375
        public void Main()
        {

            int testCase = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> dic = new();
            for (int iTest = 0; iTest < testCase; iTest++)
            {
                #region
                int cloths = int.Parse(Console.ReadLine());

                for (int j = 0; j < cloths; j++)
                {
                    string str = Console.ReadLine();
                    string[] strs = str.Split(' ');
                    if (dic.ContainsKey(strs[1]) == false)
                    {
                        dic[strs[1]] = new();
                    }
                    dic[strs[1]].Add(strs[0]);
                }
                #endregion


                


                dic.Clear();
            }
        }
    }
}
