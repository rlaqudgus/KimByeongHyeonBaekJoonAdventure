using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Bj_1009
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();
            //Input T 

            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int answer = 0;
                string[] input = Console.ReadLine().Split(" ").ToArray();

                string a = input[0];
                string b = input[1];

                if (a[a.Length - 1] - '0' == 1 || a[a.Length - 1] - '0' == 5 || a[a.Length - 1] - '0' == 6)
                {
                    answer = a[a.Length - 1]-'0';
                    sb.AppendLine(answer.ToString());
                }

                else if (a[a.Length - 1] - '0' == 0)
                {
                    sb.AppendLine("10");
                }

                else if (a[a.Length-1]-'0'==2 || a[a.Length - 1] - '0' == 3 || a[a.Length - 1] - '0' == 7 || a[a.Length - 1] - '0' == 8)
                {
                    int[] answerlist = new int[4];

                    for (int j = 0; j < 4; j++)
                    {
                        string sth = MathF.Pow((a[a.Length - 1] - '0'), j + 1).ToString();
                        int lastNum = sth[sth.Length - 1] - '0';
                        answerlist[j] = lastNum;
                    }
                    //for (int k = 0; k < answerlist.Length; k++)
                    //{
                    //    Console.WriteLine(answerlist[k]);
                    //}
                    

                    if (int.Parse(b)%4==0)
                    {
                        answer = answerlist[answerlist.Length-1];
                        sb.AppendLine(answer.ToString());
                        continue;
                    }

                    answer = answerlist[int.Parse(b) % 4 - 1];
                    sb.AppendLine(answer.ToString());
                }

                else if (a[a.Length - 1] - '0' == 4 || a[a.Length - 1] - '0' == 9)
                {
                    int[] answerlist = new int[2];

                    for (int j = 0; j < 2; j++)
                    {
                        string sth = MathF.Pow((a[a.Length - 1] - '0'), j + 1).ToString();
                        int lastNum = sth[sth.Length - 1] - '0';
                        answerlist[j] = lastNum;
                    }

                    //for (int k = 0; k < answerlist.Length; k++)
                    //{
                    //    Console.WriteLine(answerlist[k]);
                    //}

                    if (int.Parse(b) % 2 == 0)
                    {
                        answer = answerlist[answerlist.Length - 1];
                        sb.AppendLine(answer.ToString());
                        continue;
                    }

                    answer = answerlist[int.Parse(b) % 2 - 1];
                    sb.AppendLine(answer.ToString());
                }


            }

            Console.WriteLine(sb);
        }
    }
}