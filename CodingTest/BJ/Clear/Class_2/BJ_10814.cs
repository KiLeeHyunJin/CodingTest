using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BJ
{
    //https://www.acmicpc.net/problem/10814
    internal class BJ_10814
    {
        public void Main()
        {
            int userCount = int.Parse(Console.ReadLine());
            List<LinkedList<string>> userList = new List<LinkedList<string>>(100000);
            for (int i = 0; i < 100000; i++)
            {
                userList.Add(null);
            }
            for (int i = 0; i < userCount; i++)
            {
                string[] strs = Console.ReadLine().Split(' ');
                int index = int.Parse(strs[0]);
                if (userList[index] == null)
                {
                    userList[index] = new LinkedList<string>();
                }
                userList[index].AddLast(strs[1]);
            }

            for (int i = 0; i < 100000; i++)
            {
                if (userList[i] == null)
                    continue;
                foreach (var userName in userList[i])
                {
                    Console.WriteLine($"{i} {userName}");
                }
            }
        }
    }
}
