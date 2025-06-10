using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    internal class BJ_4153
    {
        public void Main()
        {
            while(true)
            {
                string[] strs = Console.ReadLine().Split(' ');

                int exitCheck = 0;
                for (int i = 0; i < strs.Count(); i++)
                {
                    if (strs[i] == "0")
                    {
                        exitCheck++;
                    }
                }
                if (strs.Count() == exitCheck)
                {
                    break;
                }


                int one = int.Parse(strs[0]);
                int two = int.Parse(strs[1]);
                int three = int.Parse(strs[2]);
                int temp = 0;

                if(one > two)
                {
                    temp = two;
                    two = one;
                    one = temp;
                }
                if(two > three)
                {
                    temp = three;
                    three = two;
                    two = temp;
                }

                if((one * one) + (two * two) == three * three)
                {
                    Console.WriteLine("right");
                }
                else
                {
                    Console.WriteLine("wrong");
                }


              
            }


        }
    }
}
