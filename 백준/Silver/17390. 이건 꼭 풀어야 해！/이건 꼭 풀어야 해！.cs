using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Bj_17390
    {
        public static void Main()
        {
            // Input 길이 N 질문 개수 Q
            StringBuilder sb = new StringBuilder();

            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            
            // Input N개의 정수를 배열로 받자
             
            List<int> listA = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<int> sumList = new List<int>();
            sumList.Add(0);

            //정렬
            listA.Sort();

            int sum = 0;

            for (int i = 0; i < input[0]; i++)
            {
                sum += listA[i];
                sumList.Add(sum);


                //for (int j = 0; j <= length[1]-1; j++)
                //{
                //    answer += listA[j];
                //}

                //for (int j = 0; j < length[0]-1; j++)
                //{
                //    sum += listA[j];
                //}

                //sb.AppendLine((answer-sum).ToString());
            }

            for (int i = 0; i < input[1]; i++)
            {
                int[] length = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                sb.AppendLine((sumList[length[1]] - sumList[length[0]-1]).ToString());
            }

            Console.WriteLine(sb);

        }

    }
}
