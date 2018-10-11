using System;



    class Program
    {
        static void Main(string[] args)
        {
        int numar;
        Console.WriteLine("Dati numar:");
        numar = int.Parse(Console.ReadLine());
        if (numar % 2 == 0)
            Console.WriteLine("{0} este un numar par.",numar);
        else
            Console.WriteLine("{0} este un numar impar.",numar);

            Console.ReadKey();
        }
    }

