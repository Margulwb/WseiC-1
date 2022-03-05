using System;

namespace ulamek
{
    class Program
    {
        static void Main(string[] args)
        {
            Ulamek a = new Ulamek(2, 3);
            Ulamek b = new Ulamek(1, 2);

            Console.WriteLine(a + b);
            Console.WriteLine();

            Console.WriteLine(a - b);
            Console.WriteLine();

            Console.WriteLine(a * b);
            Console.WriteLine();

            Console.WriteLine(a / b);
            Console.WriteLine();
        }
    }
}
/*https://dirask.com/posts/WSEI-2021-2022-lato-labN-1-ISN-Programowanie-obiektowe-lab-1-pa3ek1*/