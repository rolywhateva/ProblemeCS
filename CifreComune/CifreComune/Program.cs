using System;



    class Program
    {
        static void Main(string[] args)
        {
        int n, m, aux1, aux2;
       
        Console.Write("Dati n:");
        n = int.Parse(Console.ReadLine());
        Console.Write("Dati m:");
        m = int.Parse(Console.ReadLine());
    
        if(n<m)
        {
            aux1 = n;
            n = m;
            m = aux1;
        }
        aux2 = m;
        aux1 = n;
        bool comune = false;
      

        while(n!=0&&!comune)
        {
            m = aux2;
            while (m != 0 && !comune)
            {
                if (m % 10 == n % 10)
                    comune = true;

                m = m / 10;
            }
            n = n / 10;
            
        }
        if (comune)
            Console.WriteLine("Da!");
        else
            Console.WriteLine("Nu!");


           
            Console.ReadKey();
        }
    }

