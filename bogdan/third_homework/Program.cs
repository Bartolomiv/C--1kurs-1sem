using System;

namespace third_homework{
    class Program{
        static void Main(string[] args){
            //Ініціалізація змінних та запит числа n

            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //Перевірка на тупість
            if(n<1){
                Console.WriteLine("Wrong n");
            }else{

                bool found = false;

        for (int x = 1; x <= n; x++)
        {
            for (int y = x; y <= n; y++)
            {
                int zSquared = n - x * x - y * y;
                int z = (int)Math.Sqrt(zSquared);

                if (z * z == zSquared && z <= y)
                {
                    Console.WriteLine("Solved: x = {0}, y = {1}, z = {2}",x,y,z);
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("For n = {0} do not exist x y z.",n);
        }
            }

        }
    }
}