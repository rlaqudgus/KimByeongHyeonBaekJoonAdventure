class Bj_1427
{
    public static void Main()
    {
        //Input 정렬하려고 하는 수 N

        //string N = Console.ReadLine();

        //for (int i = 0; i < N.Length; i++)
        //{
        //    for (int j = i + 1; j < N.Length; j++)
        //    {
        //        char temp;

        //        if (N[i]-'0' > N[j]-'0')
        //        {
        //            temp = N[i];
        //            N[i] = N[j];
        //            N[j] = temp;
        //        }
        //    }
        //}
        //Console.WriteLine(N);  

        string N = Console.ReadLine();

        int[] box = new int[N.Length];

        for (int i = 0; i < N.Length; i++)
        {
            box[i] = N[i] - '0';
        }

        for (int i = 0; i < N.Length; i++)
        {
            for (int j = i + 1; j < N.Length; j++)
            {
                int temp = 0;

                if (box[i] < box[j])
                {
                    temp = box[i];
                    box[i] = box[j];
                    box[j] = temp;
                }
            }
        }

        foreach (var item in box)
        {
            Console.Write(item);
        }
    }
}