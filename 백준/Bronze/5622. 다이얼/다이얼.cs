class Bj_5622
{
    public static void Main()
    {
        //Input
        string tele = Console.ReadLine();

        //Process
        int time = 0;

        for (int i = 0; i < tele.Length; i++)
        {
            if (tele[i]=='A'|| tele[i] == 'B'|| tele[i] == 'C')
            {
                time += 3;
            }

            if (tele[i] == 'D' || tele[i] == 'E' || tele[i] == 'F')
            {
                time += 4;
            }

            if (tele[i] == 'G' || tele[i] == 'H' || tele[i] == 'I')
            {
                time += 5;
            }

            if (tele[i] == 'J' || tele[i] == 'K' || tele[i] == 'L')
            {
                time += 6;
            }

            if (tele[i] == 'M' || tele[i] == 'N' || tele[i] == 'O')
            {
                time += 7;
            }

            if (tele[i] == 'P' || tele[i] == 'Q' || tele[i] == 'R' || tele[i] == 'S')
            {
                time += 8;
            }

            if (tele[i] == 'T' || tele[i] == 'U' || tele[i] == 'V')
            {
                time += 9;
            }

            if (tele[i] == 'W' || tele[i] == 'X' || tele[i] == 'Y' || tele[i]=='Z')
            {
                time += 10;
            }
        }

        Console.WriteLine(time);
    }
}
