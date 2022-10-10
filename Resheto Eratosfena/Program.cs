using System;

class Resheto
{
    static void Main()
    {
        int num, j = 0;

        Console.WriteLine("Введите число num :");
        num = Int32.Parse(Console.ReadLine());
        int[] a = new int[num];
        for (int i = 0; i < num; i++)
        {
            a[i] = i;
        }
        a[1] = 0;
        int m = 2;
        while (m < num)
        {
            if (a[m] != 0)
                j = m * 2;
            while (j < num)
            {
                a[j] = 0;
                j = j + m;
            }
            m += 1;
        }
        foreach (int x in a)
        {
            if (x != 0)
                Console.Write(x + " ");
        }
    }
}