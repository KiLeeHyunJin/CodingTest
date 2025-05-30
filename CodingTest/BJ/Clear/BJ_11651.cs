using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    internal class BJ_11651
    {
        //https://www.acmicpc.net/problem/11651

        public class Element : IComparer<Element>, IComparable<Element>
        {
            public Element() { }
            public Element(int x, int y) { parent = x; child = y; }
            public int parent;
            public int child;

            public int Compare(Element x, Element y)
            {
                if(x.child == y.child)
                {
                    if(x.parent < y.parent)
                        return -1;
                    else
                        return 1;
                }
                else 
                    return x.child < y.child ? -1 : 1;

            }

            int IComparable<Element>.CompareTo(Element? other)
            {
                if (this.child == other.child)
                {
                    if (this.parent < other.parent)
                        return -1;
                    else
                        return 1;
                }
                else
                    return this.child < other.child ? -1 : 1;
            }
        }



        public void Main()
        {
            int testCount = int.Parse(Console.ReadLine());
            List<Element> lists = new List<Element>(testCount);
            for (int i = 0; i < testCount; i++)
            {
                string[] strs = Console.ReadLine().Split(' ');
                lists.Add(new Element(int.Parse(strs[0]), int.Parse(strs[1])));
            }

            lists.Sort();

            StringBuilder stringBuilder = new StringBuilder();
            foreach (Element element in lists)
            {
                stringBuilder.Append($"{element.parent} {element.child}\n");
            }
            Console.WriteLine(stringBuilder.ToString());    
        }
    }
}
