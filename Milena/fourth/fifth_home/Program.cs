using System;
using System.Runtime.Serialization.Formatters;

namespace fifth_home;
class Program{
    static int[,] Filler(int x,int y){
        Random rand = new Random();
        int[,] A = new int [x,y];
        for(int i = 0; i < x; i++){
                for(int n = 0; n < y;n++){
                    A[n,i] = rand.Next(0,5);
                }
            }
        for (int row = 0; row < A.GetLength(0); row++){
            for (int col = 0; col < A.GetLength(1); col++)
                Console.Write(A[row, col]+" ");
            Console.WriteLine();
        }

        return A;
        
    }

    static void sum(int [,] A){
        int x = A.GetUpperBound(0);
        int sumstrings = 0,sumrows = 0;
        int y = A.GetUpperBound(1);

        for(int i = 0; i <= x; i++){
            if(i%2 == 0){
                for(int n = 0; n <= y; n++){
                    sumstrings += A[i,n];
                }
            }
        }


        for(int i = 0; i <= x; i++){
            for(int n = 0; n <= y; n++){
                if(n%2 != 0){
                sumrows += A[i,n];
                }
            }
        }
        
        
        Console.WriteLine("Sum of strings = {0}",sumstrings); 
        Console.WriteLine("Sum of Rows = {0}",sumrows);
    }

    static void Main(string[] args){
        Console.Write("Enter number of strings: ");//Запитуємо кількість рядкуів і стовбців
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        Console.Write("Enter number of rows: ");
        int t = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");

        //Заповнюємо масив
        int [,] B = Filler(k,t);

        sum(B);

    }
}