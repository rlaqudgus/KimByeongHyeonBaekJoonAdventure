using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Bj_11047
    {
        public static void Main()
        {
            //Input 동전종류 N 과 합 K
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int N = array[0];
            int K = array[1];
            int answer = 0;

            int[] valueArray = new int[N];
            //N번 반복문돌며 값 입력 배열에 저장 
            for (int i = 0; i < N; i++)
            {
                valueArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(valueArray);

            
                for (int i = 0; i < N; i++)
                {
                    if (K - valueArray[i] < 0)
                    {
                        continue;
                    }

                    while(K - valueArray[i] >= 0)
                    {
                        K -= valueArray[i];
                        answer++;
                    }

                    //if (K == 0) return;
                }

            Console.WriteLine(answer);
            
        }
    }
}
