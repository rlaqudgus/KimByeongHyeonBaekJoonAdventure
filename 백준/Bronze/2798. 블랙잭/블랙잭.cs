class Bj_2798
{
    public static void Main()
    {
        //Input 카드의 개수 N 넘지 말아야할 선 M
        //길이가 N인 value 정수형 배열 선언 배열에서 for문 돌리기
        //string[] nmInput = Console.ReadLine().Split(" ");
        //int N = int.Parse(nmInput[0]);
        //int M = int.Parse(nmInput[1]);

        //string[] sValues = Console.ReadLine().Split(" ");

        //int[] values = new int[N];

        //for (int i = 0; i < N; i++)
        //{
        //    values[i] = int.Parse(sValues[i].ToString());
        //}


        //Process 3중for문? 최댓값 알고리즘과 M보다 작다는 2가지 조건 충족 시 출력
        //{5, 6, 7, 8, 9}

        //int maxValue = 0;

        //for (int i = 0; i < N; i++)
        //{
        //    for (int j = i + 1; j < N; j++)
        //    {
        //        for (int l = j + 1; l < N; l++)
        //        {
        //            int sum = values[i] + values[j] + values[l];

        //            if (sum >= maxValue && sum <= M)
        //            {
        //                maxValue = sum;
        //            }

        //        }
        //    }
        //}

        //Console.WriteLine(maxValue);

        //Input 첫째줄 카드개수 N, 상한선 M

        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        // 둘째줄 카드에 쓰여있는 값 배열에 집어넣기

        int[] valueInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        int maxValue = 0;

        for (int i = 0; i < input[0]; i++)
        {
            for (int j = i+1; j < input[0]; j++)
            {
                for (int l = j+1; l < input[0]; l++)
                {
                    int sum = valueInput[i] + valueInput[j] + valueInput[l];

                    if (sum>maxValue && sum <= input[1])
                    {
                        maxValue = sum;
                    }
                }
            }
        }

        Console.WriteLine(maxValue);


    }
}

