using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    internal class BJ_4949
    {
        /// <summary>
        /// 코드 정리 필요
        /// </summary>
        public void Main()
        {
            StringBuilder sb = new StringBuilder();
            Stack<char> st = new Stack<char>();
            while(true)
            {
                string[] strs = Console.ReadLine().Split(' ');
                if(strs.Length == 1)
                {
                    if (strs[0].Length == 1 && strs[0] == ".")
                        break;
                }

                bool fail = false;
                for (int i = 0; i < strs.Length; i++)
                {
                    for (int j = 0; j < strs[i].Length; j++)
                    {
                        if (strs[i][j] == '.')
                        {
                            fail = true;
                            break;
                        }

                        if (
                          strs[i][j] == '[' ||
                          strs[i][j] == '(' ||
                          strs[i][j] == '{')
                        {
                            st.Push(strs[i][j]);
                        }
                        else if(
                              strs[i][j] == ']' ||
                              strs[i][j] == ')' ||
                              strs[i][j] == '}')
                        {
                            if(st.Count() == 0)
                            {
                                for (int k = 0; k < 100; k++)
                                {
                                    st.Push('[');
                                    fail = true;
                    
                                }
                                break;
                            }
                            st.TryPeek(out char lastGualho);
                            if (strs[i][j] == ']')
                            {
                                if (lastGualho != '[')
                                {
                                    fail = true;
                                }
                            }
                            else if (strs[i][j] == ')')
                            {
                                if (lastGualho != '(')
                                {
                                    fail = true;
                                }
                            }
                            else
                            {
                                if (lastGualho != '{')
                                {
                                    fail = true;
                                }
                            }
                            if(fail == false)
                            {
                                st.Pop();
                            }
                        }
                      
                    }
                    if (fail)
                    {
                        break;
                    }

                }

                if (st.Count() == 0)
                {
                    sb.Append("yes \n");
                }
                else
                {
                    sb.Append("no \n");
                }
                st.Clear();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
