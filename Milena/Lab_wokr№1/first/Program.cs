using System;
namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            //Завдання перше
            int weight = 53;
            double stouns;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("Hi");
            Console.WriteLine("Sahrian Milena");
            Console.Write("My Weight is ");
            stouns = weight/6.350293;
            //Math.Round(stouns, 2);
            Console.WriteLine("{0:F2}", stouns);

            //Завдання друге
            int l_metr ;
            double l_mile;
            double l_cabel;

            Console.Write("Please enter lenght ");
            l_metr = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            l_cabel = l_metr/185.3182;

            l_mile = l_cabel/10;

            Console.WriteLine("Lenght in sea miles {0:F3}" ,l_mile);
            Console.WriteLine("Lenght in cable miles {0:F3}" ,l_cabel);
            Console.WriteLine(" ");

            //Завдання 3
            double x;
            double z1;
            double z2;
            double z3;

            Console.Write("Enter x ");
            x = double.Parse(Console.ReadLine());

            z1 = (Math.Pow(Math.Sin(x), 4) + Math.Pow(Math.Sin(x), 2) + (Math.Cos(Math.PI*x))/4);
            z2 = (Math.Tan(x * 3/4) - 4);
            z3 = (Math.Sin(3 * x))/(Math.Sqrt(Math.Abs(x) + 2));

            Console.WriteLine("z1 = {0:F3}", z1);
            Console.WriteLine("z2 = {0:F3}", z2);
            Console.WriteLine("z3 = {0:F3}", z3);


            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}

