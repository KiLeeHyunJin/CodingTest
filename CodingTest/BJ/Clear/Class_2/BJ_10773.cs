using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    internal class BJ_10773
    {
        public void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(count);
            
            for (int i = 0; i < count; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(input);
                }
            }
            int result = 0;
            while(stack.Count != 0)
            {
                result += stack.Pop();
            }
            Console.WriteLine(result);
        }
    }
}
