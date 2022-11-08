using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Bj_10816
    {
        //public static List<int> BinarySearch(List<int> list, int target, int start, int end)
        //{
        //    int mid = 0;
        //    List<int> result = new List<int>();

        //    while (start <= end)
        //    {
        //        mid = (start + end) / 2;

        //        if (list[mid] == target)
        //        {
        //            for (int i = 0; i < end-start+1; i++)
        //            {
        //                result.Add(list[i + start]);
        //            }   

        //            return result;
        //        }

        //        else if (list[mid] > target)
        //        {
        //            end = mid - 1;
        //        }

        //        else start = mid + 1;
        //    }

        //    return result;
        //}

        public static void Main()
        {
            //StringBuilder sb = new StringBuilder();
            ////Input 숫자카드개수 N 요소들 구해야 할 정수 개수 M 정수들

            //int N = int.Parse(Console.ReadLine());

            //List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            //input.Sort();

            //int M = int.Parse(Console.ReadLine());

            //List<int> input2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();


            ////process Contains이면 수 세서 출력 !Contains면 0 출력
            //for (int i = 0; i < input2.Count; i++)
            //{
            //    int count = 0;

            //    //if (!input.Contains(input2[i]))
            //    //{
            //    //    sb.Append("0 ");
            //    //}

            //    List<int> answerList = BinarySearch(input, input2[i], 0, N - 1);

            //    for (int j = 0; j < answerList.Count; j++)
            //    {
            //        if (input2[i] == answerList[j])
            //        {
            //            count++;

            //            if (j + 1 < answerList.Count && answerList[j + 1] != input2[i] )
            //            {
            //                break;
            //            }
            //        }
            //    }

            //    sb.Append(count + " ");

            //}

            //Console.WriteLine(sb);

            StringBuilder sb = new StringBuilder();

            //Input dictionary에 수를 key로 수의 반복횟수를 value로 지정

            int N = int.Parse(Console.ReadLine());

            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int M = int.Parse(Console.ReadLine());

            List<int> input2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            input.Sort();

            Dictionary<int, int> inputDict = new Dictionary<int, int>();
            
            //만약 다음 원소와 현재 원소가 같다면 키 추가하지 말고 valuecount만 올리기 continue
            int valueCount = 1;

            for (int i = 0; i < input.Count; i++)
            {
                if (i<input.Count-1 && input[i] == input[i+1])
                {
                    valueCount++;

                    continue;
                }

                inputDict.Add(input[i], valueCount);

                valueCount = 1;
            }

            

            for (int i = 0; i < input2.Count; i++)
            {
                int answer = inputDict.TryGetValue(input2[i], out valueCount) ? valueCount : 0;

                sb.Append(answer + " ");
            }

            Console.WriteLine(sb);
        }
    }
}
