using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Test
    {
        //Stack
        //    static StringBuilder sb = new StringBuilder();
        //    static List<int> myList = new List<int>();

        //    public static void Stack(string order)
        //    {
        //        switch (order)
        //        {
        //            case "pop":
        //                if (myList.Count==0)
        //                {
        //                    sb.AppendLine("-1");
        //                }
        //                else
        //                {
        //                    int a = myList[myList.Count - 1];
        //                    sb.AppendLine(a.ToString());
        //                    myList.RemoveAt(myList.Count - 1);
        //                }

        //                break;
        //            case "size":
        //                int b = myList.Count;
        //                sb.AppendLine(b.ToString());
        //                break;
        //            case "empty":
        //                int c = myList.Count == 0 ? 1 : 0;
        //                sb.AppendLine(c.ToString());
        //                break;
        //            case "top":
        //                int d = myList.Count == 0 ? -1 : myList[myList.Count - 1];
        //                sb.AppendLine(d.ToString());
        //                break;
        //        }
        //    }

        //    public static void Stack(string order, int num)
        //    {
        //        myList.Add(num);
        //    }

        //    public static void Main()
        //    {
        //        int count = int.Parse(Console.ReadLine());

        //        for (int i = 0; i < count; i++)
        //        {
        //            string[] input = Console.ReadLine().Split(" ");

        //            if (input.Length == 2)
        //            {
        //                Stack("push", int.Parse(input[1]));
        //            }

        //            else Stack(input[0]);
        //        }

        //        Console.WriteLine(sb);
        //    }

        //Hansu
        //public static void Main()
        //{
        //    string N = Console.ReadLine();
        //    int count = 0;
        //    //1~99까지는 무조건 한수
        //    for (int i = 1; i <= int.Parse(N); i++)
        //    {
        //        if (i<100)
        //        {
        //            count++;
        //            continue;
        //        }

        //        //int a = int.Parse(i.Substring(0, 1));
        //        //int b = int.Parse(N.Substring(1, 1));
        //        //int c = int.Parse(N.Substring(2, 1));
        //        string istring = i.ToString();
        //        int a = (int)istring[0];
        //        int b = (int)istring[1];
        //        int c = (int)istring[2];

        //        if (a-b==b-c)
        //        {
        //            count++;
        //        }
        //    }    
        //    Console.WriteLine(count);   
        //}

        //ACM Hotel
        //TestCase
        //public static void Main()
        //{
        //    int T = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < T; i++)
        //    {
        //        //HWN
        //        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        //        int H = input[0];
        //        int W = input[1];
        //        int N = input[2];

        //        //방번호 초기화

        //        int x = 1;
        //        int y = 1;

        //        while(true)
        //        {
        //            if (N > H)
        //            {
        //                N -= H;
        //                y++;
        //            }

        //            else
        //            {
        //                x = N;
        //                break;
        //            }
        //        }

        //        Console.WriteLine("{0}{1:00}", x, y);
        //    }
        //}

        //public static void Main()
        //{
        //    int input = int.Parse(Console.ReadLine());

        //    int cnt = 1;
        //    long range = 1;
        //    long temp = 1;

        //    while (true)
        //    {
        //        if (range>=input)
        //        {
        //            break;
        //        }

        //        temp = 6 * cnt++;

        //        range += temp;
        //    }

        //    Console.WriteLine(cnt);
        //}

        //    public static void Main()
        //    {
        //        //input
        //        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        //        int A = input[0];
        //        int B = input[1];
        //        int C = input[2];

        //        int answer = 0;

        //        if (B>=C)
        //        {
        //            answer = -1;
        //        }

        //        else
        //        {
        //            answer = A / (C - B) + 1;
        //        }

        //        Console.WriteLine(answer);
        //    }
        //fibonacci

        //static int Fibo(int input)
        //{
        //    if (input==0)
        //    {
        //        return 0;
        //    }
        //    if (input==1)
        //    {
        //        return 1;
        //    }

        //    return Fibo(input-1)+Fibo(input-2);
        //}

        //public static void Main()
        //{
        //    int n = int.Parse(Console.ReadLine());

        //    Console.WriteLine(Fibo(n));
        //}
        
        //동전 0
        //public static void Main()
        //{
        //    //Input
        //    int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        //    int N = input[0];
        //    int K = input[1];

        //    int[] value = new int[N];

        //    int answer = 0;

        //    for (int i = 0; i < N; i++)
        //    {
        //        value[i] = int.Parse(Console.ReadLine());
        //    }

        //    Array.Reverse(value);

        //    //process K가 0이 될때까지 큰수부터 빼줌

        //    for (int i = 0; i < N; i++)
        //    {
        //        if (value[i] > K) continue;
        //        if (K == 0) break;

        //        while (K - value[i] >= 0)
        //        {
        //            K -= value[i];
        //            answer++;
        //        }
        //    }

        //    Console.WriteLine(answer);
           
        //}

        //이분탐색 수찾기

        //public static void Main()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    int N = int.Parse(Console.ReadLine());

        //    int[] Aarray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        //    Array.Sort(Aarray);

        //    int M = int.Parse(Console.ReadLine());

        //    int[] Barray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        //    for (int i = 0; i < Barray.Length; i++)
        //    {
        //        int start = 0;

        //        int end = N - 1;

        //        int middle = 0;

        //        int result = 0;

        //        while (start<=end)
        //        {
        //            middle = (start + end) / 2;

        //            if (Aarray[middle] == Barray[i])
        //            {
        //                result = 1;
        //                break;
        //            }

        //            else if (Aarray[middle] < Barray[i])
        //            {
        //                start = middle + 1;
        //            }

        //            else 
        //            {
        //                end = middle - 1;
        //            }
        //        }

        //        sb.AppendLine(result.ToString());
        //    }

        //    Console.WriteLine(sb);
        //}
        //BlackJack

        //public static void Main()
        //{
        //    //Input N M
        //    int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        //    int N = input[0];
        //    int M = input[1];

        //    int[] cardArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        //    Array.Sort(cardArray);

        //    int answer = 0;
        //    int finalAnswer = 0;

        //    for (int i = 0; i < N; i++)
        //    {
        //        for (int j = i+1; j < N; j++)
        //        {
        //            for (int l = j+1; l < N; l++)
        //            {
        //                finalAnswer = cardArray[i] + cardArray[j] + cardArray[l];
        //                if (finalAnswer>answer && finalAnswer<=M)
        //                {
        //                    answer = finalAnswer;
        //                }
        //            }
        //        }
        //    }

        //    Console.WriteLine(answer);

        //}

        //Chess

        //public static void Main()
        //{
        //    //Input N M
        //    int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        //    int N = input[0];
        //    int M = input[1];

        //    int answer = 64;

        //    //2중 for문으로 2차원 배열에 BW 저장

        //    char[,] bwArray = new char[N, M];

        //    for (int i = 0; i < N; i++)
        //    {
        //        string bwLine = Console.ReadLine();

        //        for (int j = 0; j < M; j++)
        //        {
        //            bwArray[i, j] = bwLine[j];
        //        }
        //    }

        //    //시작점의 움직임

        //    for (int i = 0; i <= N-8; i++)
        //    {
        //        for (int j = 0; j <= M-8; j++)
        //        {
        //            //시작점에서 출발하는 움직임. 조건에 따라 count를 1씩 더해준다
        //            int count = 0;

        //            for (int k = i; k < i+8; k++)
        //            {
        //                for (int l = j; l < j+8; l++)
        //                {
        //                    //규칙 : 2차원 배열의 인덱스값을 더해서 2로 나누어떨어지면 W, 아니면 B
        //                    char myChar = (k + l) % 2 == 0 ? 'W' : 'B';

        //                    if (myChar != bwArray[k,l])
        //                    {
        //                        count++;
        //                    }
        //                }
        //            }

        //            //시작점이 초기화될때마다 count도 초기화시켜줘야함 B가 먼저 오는지 W가 먼저 오는지에 따라 다르게
        //            //answer에 제일 작은 값의 count를 저장

        //            count = Math.Min(count, 64-count);
        //            answer = Math.Min(answer, count);
        //        }
        //    }

        //    Console.WriteLine(answer);
        //}

        //string repeat

        //public static void Main()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    //Input T
        //    int T = int.Parse(Console.ReadLine());

        //    // R S
        //    for (int i = 0; i < T; i++)
        //    {
        //        string[] input = Console.ReadLine().Split(" ").ToArray();

        //        int R = int.Parse(input[0]);
        //        string S = input[1];

        //        for (int j = 0; j < S.Length ; j++)
        //        {
        //            for (int k = 0; k < R; k++)
        //            {
        //                sb.Append(S[j]);
        //            }
                    
        //        }
        //        sb.Append("\n");
        //    }

        //    Console.WriteLine(sb);
        //}

        //Dial

        public static void Main()
        {
            //Input 
            string input = Console.ReadLine();

            int answer = 0;

            //각 알파벳마다 정수 할당
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'A' || input[i]=='B'|| input[i]=='C')
                {
                    answer += 3;
                }

                if (input[i] == 'D' || input[i] == 'E' || input[i] == 'F')
                {
                    answer += 4;
                }

                if (input[i] == 'G' || input[i] == 'H' || input[i] == 'I')
                {
                    answer += 5;
                }

                if (input[i] == 'J' || input[i] == 'K' || input[i] == 'L')
                {
                    answer += 6;
                }

                if (input[i] == 'M' || input[i] == 'N' || input[i] == 'O')
                {
                    answer += 7;
                }

                if (input[i] == 'P' || input[i] == 'Q' || input[i] == 'R' || input[i] == 'S')
                {
                    answer += 8;
                }

                if (input[i] == 'T' || input[i] == 'U' || input[i] == 'V')
                {
                    answer += 9;
                }

                if (input[i] == 'W' || input[i] == 'X' || input[i] == 'Y' || input[i] == 'Z')
                {
                    answer += 10;
                }

            }

            Console.WriteLine(answer);
        }

    }

}
