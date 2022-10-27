using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Bj_11399
    {
        public static void Main()
        {
            //Input 사람의 수 N 각 사람 돈인출 시간 Pn
            int N = int.Parse(Console.ReadLine());
            int[] times = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            // process 오름차순으로 정렬해야 최솟값을 구할 수 있을듯
            // P1+(P1+P2)+(P1+P2+P3)+(P1+P2+P3+P4)+(P1+P2+P3+P4+P5)

            Array.Sort(times);

            int answer = 0;
            int finalAnswer = 0;

            for (int i = 0; i < N; i++)
            {
                answer += times[i];
                finalAnswer += answer;
            }

            Console.WriteLine(finalAnswer);
        }
    }
}
