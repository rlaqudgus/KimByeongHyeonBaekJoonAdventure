using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Codingcoding.Baekjoon
{
    internal class Bj_1712
    {
        public static void Main()
        {
            //Input 고정비용 A 가변비용 B 판매비용 C

            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int A = input[0];
            int B = input[1];
            int C = input[2];

            if (B>=C)
            {
                Console.WriteLine(-1);

            }

            else
            {
                int answer = A / (C - B) + 1;

                Console.WriteLine(answer);
            }
            
        }
    }
}
