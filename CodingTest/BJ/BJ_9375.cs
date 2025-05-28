using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    public class BJ_9375
    {
        public void Main()
        {

            int testCase = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> dic = new();
            HashSet<string> hs = new();
            List<KeyValuePair<string, List<string>>> searchList = new();
            for (int iTest = 0; iTest < testCase; iTest++)
            {
                int cloths = int.Parse(Console.ReadLine());

                for (int j = 0; j < cloths; j++)
                {
                    string str = Console.ReadLine();
                    string[] strs = str.Split(' ');
                    if (dic.ContainsKey(strs[1]) == false)
                    {
                        dic[strs[1]] = new List<string>();
                    }
                    if(hs.Contains(strs[0]) == false)
                    {
                        dic[strs[1]].Add(strs[0]);
                    }
                }



                foreach (var item in dic)
                {
                    searchList.Add(item);
                }


                int result = 0;


                for (int i = 0; i < searchList.Count(); i++) 
                {
                    result++;//낱개

                    int total = searchList[i].Value.Count(); //최대 경우의 수
                    int count = 0;
                    for (int j =  i + 1; j < searchList.Count(); j++)
                    {
                        result++; //2개
                        if(j <= searchList.Count() - 2)
                        {
                            total *= searchList[j].Value.Count();
                        }


                    }
                    result += count ;
                    result += total;

                }
                Console.WriteLine(result);
                
                searchList.Clear();
                dic.Clear();
                hs.Clear();
            }
        }
    }
}
