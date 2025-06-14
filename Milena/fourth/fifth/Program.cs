using System;

namespace fifth{
    class Program{
        
        static void Method_1(double form_x){
            if(form_x < 0){
                form_x = form_x*(-1);
            } else {
                form_x = Math.Sqrt(form_x);
            }
            Console.WriteLine("In Method_1: form_x = {0}",form_x);
        }

        static void Method_2(ref double form_x){
            if(form_x < 0){
                form_x = form_x*(-1);
            } else {
                form_x = Math.Sqrt(form_x);
            }
            Console.WriteLine("In Method_2: form_x = {0}",form_x);
        }

        static int[] Method_3_1(){
            Random rand = new Random();
            Console.WriteLine("Enter number of array charecters: ");    //Питання кількості знаків
            int n = int.Parse(Console.ReadLine()); 
            int[] A = new int [n];                                     //Створення масиву

            for(int i = 0; i < n; i++){
                A[i] = rand.Next(0,5);
               // Console.Write("{0} \t",A[i]);
            }
            Console.WriteLine(" ");
            return A;
        }

        static void Method_3_2(out int[]A){
            Random rand = new Random();
            Console.WriteLine("Enter number of array charecters: ");    //Питання кількості знаків
            int n = int.Parse(Console.ReadLine()); 
            A = new int [n];                                     //Створення масиву

            for(int i = 0; i < n; i++){
                A[i] = rand.Next(0,5);
               // Console.Write("{0} \t",A[i]);
            }
            Console.WriteLine(" ");
        }
    

        static void Main(string[] args){
            //Завдання 1
            Random rand = new Random();
            Console.WriteLine("Enter number of array charecters: ");    //Питання кількості знаків
            int n = int.Parse(Console.ReadLine());                      //Запит
            int[] A = new int [n];                                      //Створення масиву

            for(int i = 0; i < n; i++){
                A[i] = rand.Next(20,40);
                Console.Write("{0} \t",A[i]);
            }
            Console.WriteLine(" ");

            //Завдання 2

            Console.Write("Enter x: ");
            double real_x = double.Parse(Console.ReadLine());

            Method_1(real_x);

            Console.WriteLine("In Main: real_x = {0}",real_x);

            //Завдання 3

            Method_2(ref real_x);

            Console.WriteLine("In Main: real_x = {0}",real_x);

            //Завдання 4;
            int[] b = Method_3_1();
            foreach(int i in b){
                Console.Write("{0} \t", i);
            }
            Console.WriteLine();

            Method_3_2(out b);
            foreach(int i in b){
                Console.Write("{0} \t", i);
            }
            Console.WriteLine();
            


            //Кінець програми
            /*Console.WriteLine("Press any key to close");
            Console.ReadLine();*/
        }
    }
}