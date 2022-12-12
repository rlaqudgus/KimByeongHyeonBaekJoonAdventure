using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Test
    {
        static StringBuilder sb = new StringBuilder();
        static List<int> myList = new List<int>();

        public static void Stack(string order)
        {
            switch (order)
            {
                case "pop":
                    if (myList.Count==0)
                    {
                        sb.AppendLine("-1");
                    }
                    else
                    {
                        int a = myList[myList.Count - 1];
                        sb.AppendLine(a.ToString());
                        myList.RemoveAt(myList.Count - 1);
                    }
                    
                    break;
                case "size":
                    int b = myList.Count;
                    sb.AppendLine(b.ToString());
                    break;
                case "empty":
                    int c = myList.Count == 0 ? 1 : 0;
                    sb.AppendLine(c.ToString());
                    break;
                case "top":
                    int d = myList.Count == 0 ? -1 : myList[myList.Count - 1];
                    sb.AppendLine(d.ToString());
                    break;
            }
        }

        public static void Stack(string order, int num)
        {
            myList.Add(num);
        }

        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                if (input.Length == 2)
                {
                    Stack("push", int.Parse(input[1]));
                }

                else Stack(input[0]);
            }

            Console.WriteLine(sb);
        }
    }
}
