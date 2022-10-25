using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Bj_10828
    {
        static List<int> myList = new List<int>();
        static StringBuilder sb= new StringBuilder();
        static void Stack(string input)
        {
            switch (input)
            {
                case "pop":
                    if (myList.Count==0)
                    {
                        sb.AppendLine("-1");
                        //Console.WriteLine("-1");
                    }
                    else
                    {
                        sb.AppendLine(myList[myList.Count - 1].ToString());
                        //Console.WriteLine(myList[myList.Count - 1]);
                        myList.RemoveAt(myList.Count - 1);
                    }
                    break;

                case "size":
                    sb.AppendLine(myList.Count.ToString());
                    //Console.WriteLine(myList.Count);
                    break;

                case "empty":
                    int answer = myList.Count == 0 ? 1 : 0;
                    sb.AppendLine(answer.ToString());
                    //Console.WriteLine(answer);
                    break;

                case "top":
                    int answer2 = myList.Count == 0 ? -1 : myList[myList.Count - 1];
                    sb.AppendLine(answer2.ToString());
                    //Console.WriteLine(answer2);
                    break;
            }

                
        }
        static void Stack(string input,int X)
        {
            myList.Add(X);

        }
        public static void Main()
        {
            //Input testcase N

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                if (input.Length == 2)
                {
                    Stack(input[0], int.Parse(input[1]));
                }

                if (input.Length == 1)
                {
                    Stack(input[0]);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
