using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    internal class BJ_10816
    {
        public void Main()
        {
            int nCount = int.Parse(Console.ReadLine());
            int[] ns = new int[nCount];
            string[] strNs = Console.ReadLine().Split(' ');
            Dictionary<int,int> nDic = new Dictionary<int,int>();
            for (int i = 0; i < nCount; i++)
            {
                int input = int.Parse(strNs[i]);
                if (nDic.ContainsKey(input))
                {
                    nDic[input]+= 1;
                }
                else
                {
                    nDic.Add(input, 1);
                }
            }
            int mCount = int.Parse(Console.ReadLine());
            int[] ms = new int[nCount];
            string[] strMs = Console.ReadLine().Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < mCount; i++)
            {
                int input = int.Parse(strMs[i]);

                if (nDic.ContainsKey(input))
                {
                    sb.Append($"{nDic[input]} ");
                }else
                {
                    sb.Append("0 ");
                }
            }

            Console.WriteLine(sb.ToString());


        }
    }
}
