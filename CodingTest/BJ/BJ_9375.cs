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

            Dictionary<int, LinkedList<string>> dic = new();                        
            HashSet<int> ints = new HashSet<int>();
            List<KeyValuePair<int, LinkedList<string>>> searchList = new();
            for (int i = 0; i < testCase; i++)
            {
                int cloths = int.Parse(Console.ReadLine());

                for (int j = 0; j < cloths; j++)
                {
                    string[] strs = Console.ReadLine().Split(' ');
                    int hashCode = strs[1].GetHashCode();
                    if (dic.ContainsKey(hashCode) == false)
                    {
                        dic[hashCode] = new LinkedList<string>();
                    }
                    dic[hashCode].AddLast(strs[0]);
                }



                foreach (var item in dic)
                {
                    searchList.Add(item);
                }
                int count = 0;
                foreach(var item in searchList)
                {
                    foreach (var item2 in item.Value)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);

                dic.Clear();
                ints.Clear();
            }

            Console.WriteLine("종료");


            string[] strArr = new string[2];
        }
    }
}
