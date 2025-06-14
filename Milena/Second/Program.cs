using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Завдання 1
            Console.Write("Enter n: ");
            String n = Console.ReadLine();
            int N = int.Parse(n);

            switch(n){
                case "One": Console.WriteLine(1%5);
                break;

                case "Two": Console.WriteLine(2%5);
                break;

                case "Three": Console.WriteLine(3%5);
                break;

                case "Four": Console.WriteLine(4%5);
                break;

                case "Five": Console.WriteLine(1);
                break;
            }


                switch(N%5){

                case 1: Console.WriteLine("One");
                break;

                case 2: Console.WriteLine("Two");
                break;

                case 3: Console.WriteLine("Three");
                break;

                case 4: Console.WriteLine("Four");
                break;

                case 5: Console.WriteLine("Zero");
                break;
                }

            Console.WriteLine(" ");
            

            //Завдання 2

            Console.WriteLine("Enter x,y: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = 0;

            if(Math.Abs(y-1) <= 2){
                if(x/2 < y*y){
                    z = x/2;
                } else {
                    z = y*y ;
                } 
            } else {
                if(2*x-y > y){
                    z = 2*x-y;
                } else {
                    z = y;
                }
            }
            Console.WriteLine("Z = {0}",z);

            //Завдання 3

            Console.WriteLine("Enter c,a,b: ");
            int c = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            bool boo;

            if((c > a &&  c > b) || (c < a && c<b)){
                boo = true;
            } else {
                boo = false;
            }

            boo = ((c > a && c > b) || (c < a && c < b)) ? true : false;

            Console.WriteLine("boo = {0}",boo);
            
            //Домашне завдання №9

            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            if((year % 4 == 0 && year % 100 != 0) || (year%100 == 0 && year%400 == 0)){
                Console.WriteLine("366");
            } else {
                Console.WriteLine("365");
            }

            //Домашне завдання №46
            Console.WriteLine("Enter number of part and value: ");
            double r1 = 0, r2 = 0, o = 0, s = 0;
            int p = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());

            switch (p){
                case 1: 
                o = x;
                r1 = x/(2 * Math.Sqrt(3));
                r2 = x/Math.Sqrt(3);
                s = x*x*Math.Sqrt(3)/4;
                break;

                case 2:
                r1 = x;
                o = r1*(2 * Math.Sqrt(3));
                r2 = o/Math.Sqrt(3);
                s = o*o*Math.Sqrt(3)/4;
                break;
                
                case 3:
                r2 = x;
                o = r2*Math.Sqrt(3);
                r1 = o/(2 * Math.Sqrt(3));
                s = o*o*Math.Sqrt(3)/4;
                break;

                case 4:
                s = x;
                o = Math.Sqrt((s*Math.Sqrt(3))/4);
                r1 = o/(2 * Math.Sqrt(3));
                r2 = o/Math.Sqrt(3);
                break;

                default:
                Console.WriteLine("You entered wrong number");
                break;
            };
            Console.WriteLine("R1 = {0:F2}, R2 = {1:F2}, S = {2:F2}, A = {3:F2}", r1, r2, s, o);
            
            //End of The Program
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
