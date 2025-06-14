using System;

class Program
{
    static void Main()
    {
        //Зчитування кількості елементів массиву
            Random rand = new Random();
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int [n];
            for(int i = 0; i < n; i++){
                array[i] = rand.Next(1,5);
            }
            PrintArray(array);
            Console.WriteLine(" ");

        // Завдання 1: Створити новий масив без елементів, які зустрічаються менше двох разів
        int[] newArray1 = RemoveElementsLessThanTwice(array);
        Console.WriteLine("\nНовий масив без елементів, які зустрічаються менше двох разів:");
        PrintArray(newArray1);

        

        // Завдання 2: Створити новий масив без елементів, які зустрічаються рівно двічі
        int[] newArray2 = RemoveElementsExactlyTwice(array);
        Console.WriteLine("\nНовий масив без елементів, які зустрічаються рівно двічі:");
        PrintArray(newArray2);
    }

    static int[] RemoveElementsLessThanTwice(int[] array)
    {
        var counts = new Dictionary<int, int>(); // Використовуємо етакий словник для запису елементів яких менше ніж 2

        for (int i = 0; i < array.Length; i++)
        {
            if (!counts.ContainsKey(array[i]))
            {
                counts[array[i]] = 1;
            }
            else
            {
                counts[array[i]]++;
            }
        }

        var result = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (counts[array[i]] >= 2)
            {
                result.Add(array[i]);
            }
        }

        return result.ToArray();
    }

    static int[] RemoveElementsExactlyTwice(int[] array)
    {
        int count = 0;
        int length = array.Length;  

            length = array.Length;         

            for(int i = 0; i < array.Length; i++){
                for(int j = 0; j < array.Length; j++){
                    if(array[i] == array[j]){
                        count += 1;
                        
                    }
                }
                if(count == 2){
                    length -= 1;
                    array[i] = 0;
                }
            }
            int[] B = new int[length];

            for(int i = 0; i < array.Length; i++){
                if(array[i] == 0 && i+1 < array.Length){
                    B[i] = array[i+1];
                }else{
                    B[i] = array[i];
                }
            }

            return B;
    }

    static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
