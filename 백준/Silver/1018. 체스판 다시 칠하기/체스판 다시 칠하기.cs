using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Bj_1018
    {
        public static void Main()
        {
            //BruteForce 문제 완전탐색

            //Input N과 M

            int[] nmInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int N = nmInput[0];

            int M = nmInput[1];

            //B or W 로 이루어진 체스판

            //process 2차원 배열에 입력값을 저장하자

            char[,] bwInput = new char[N, M];

            for (int i = 0; i < N; i++)
            {
                string name = Console.ReadLine();

                for (int j = 0; j < M; j++)
                {
                    bwInput[i, j] = name[j];
                }
            }

            //시작점의 움직임
            int count = 64;

            for (int i = 0; i <= N - 8; i++)
            {
                for (int j = 0; j <= M - 8; j++)
                {
                    //시작점에서 차이점 확인하는 움직임
                    int num = 0;

                    for (int k = i; k < i + 8; k++)
                    {
                        for (int l = j; l < j + 8; l++)
                        {
                            char check = (k + l) % 2 == 0 ? 'W' : 'B';

                            if (check != bwInput[k, l])
                            {
                                num++;
                            }
                        }
                    }

                    num = Math.Min(num, 64 - num);
                    count = Math.Min(count, num);
                }
            }

            Console.WriteLine(count);



        }  
    }
}
