using System;



    class Program
    {
        static void Main(string[] args)
        {
        int[] ar;
        int  n;
        Console.WriteLine("n=");
        n = int.Parse(Console.ReadLine());
        ar = new int[n];
        int nr = 0;
        int[] frec = new int[101];

        for(int i=0;i<n;i++)
        {
            Console.Write("Tipul sosetei {0}:", i + 1);
            ar[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            frec[ar[i]]++;
            if (frec[ar[i]] >= 2)
            {
                nr++;
                frec[ar[i]] = 0;
            }


        }

        Console.WriteLine("Nr de perechi complete : "+nr );
            Console.ReadKey();
        }
    }

