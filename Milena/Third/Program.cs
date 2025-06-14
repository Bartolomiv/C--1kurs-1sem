using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            //Завдання;

            
            //Завдання 1
            int n, i, s;
            n = int.Parse(Console.ReadLine ());
            i = 1;
            s = 0;

            while(i <= n){
                s += i;
                i++;
            }

            Console.WriteLine ("i = {0}  s = {1}", i, s);

            i = 0;
            s = 0;

            while(i < n){
                i++;
                s += i;
            }

            Console.WriteLine ("i = {0}  s = {1}", i, s);

            i = 0;
            s = 0;

            for(;i < n;i++){
                s += i + 1;
            }

            Console.WriteLine("i = {0}  s = {1}", i, s);

            i = 0;
            s = 0;

            for(;i < n;++i){
                s += i + 1;
            }

            Console.WriteLine("i = {0}  s = {1}", i, s);

//          Завдання 2
            i = 0;
            s = 0;

            do            
            {
                i++;
                s += i;
            } while (i < n);

            Console.WriteLine ("i = {0}  s = {1}", i, s);

            //Завдання 3
            Console.Write("Enter n: ");
            n = int.Parse(Console.ReadLine());
            double s1 = 0;

            for(double k = 3.0; k + 1 < n; k+=3){
                s1 += 1.0 / (k *(k + 1.0));
                //Console.WriteLine("_S = {0:F5}", s1);
            }

            Console.WriteLine("S = {0:F5}", s1);

            

            //Домашне завдання №2
            double g = 9.8;
            Console.Write("Enter t = ");
            int t = int.Parse(Console.ReadLine());

            if(t > 0){
            i = 1;
            double v = 0;

            while(i < t){
                v = g * i;
                Console.WriteLine("t = {0}, v = {1:F2}",i,v);
                i++;
            }

            Console.WriteLine(" ");

            i = 1;
            do{
                v = g * i;
                Console.WriteLine("t = {0}, v = {1:F2}",i,v);
                i++;
            } while(i < t);

            Console.WriteLine(" ");

            for(i = 1; i < t;++i){
                v = g * i;
                Console.WriteLine("t = {0}, v = {1:F2}",i,v);
                
            }

            Console.WriteLine(" ");

            }else {
                Console.WriteLine("Invalid data");
            }


            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
