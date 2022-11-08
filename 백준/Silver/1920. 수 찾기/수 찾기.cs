using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Bj_1920
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();
            //Input 배열 길이 N 배열요소 A 두번째 배열길이 M 두번째 배열요소 X

            int N = int.Parse(Console.ReadLine());

            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int M = int.Parse(Console.ReadLine());

            List<int> input2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            for (int i = 0; i < input2.Count; i++)
            {
                if (input.Contains(input2[i]))
                {
                    sb.AppendLine("1");
                }

                else sb.AppendLine("0");
            }

            Console.WriteLine(sb);
        }
    }
}
