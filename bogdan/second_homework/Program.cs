using System;

namespace second_homework{
    class Program{
        static void Main(string[] args){
            int day, mounth, year;

            //зчитування данних
            Console.Write("Enter day: ");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter mounth: ");
            mounth = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter Year: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Перевірка на тупість користувача
            if(mounth<13 && mounth>0 && day>0 && day<32){
                if((mounth == 2 && day > 28) || ((mounth == 4 || mounth == 6 || mounth == 8 || mounth == 10) && day > 30)){
                    Console.WriteLine("Wrong day of mounth");
                } else {  //Основна програма обчислення

                    switch(day){
                        //найгірший варіант якщо день у нас 1
                        case 1:

                            if(mounth>1 ){
                                switch(mounth){
                                    //заміна значень в залежності від місяця і кількості днів в ньому
                                    case 3:
                                    day = 28;
                                    mounth -= 1;
                                    break;

                                    case 5:
                                    day = 30;
                                    mounth -= 1;
                                    break;

                                    case 7:
                                    day = 30;
                                    mounth -= 1;
                                    break;

                                    case 10:
                                    day = 30;
                                    mounth -= 1;
                                    break;

                                    default:
                                    day = 31;
                                    mounth -= 1;
                                    break;
                                }
                            }else{ // випадок 1 дня 1 місяця
                                    day = 31;
                                    mounth = 12;
                                    year -= 1;
                                }

                        break;
                        
                        //Тут все легко якщо день не 1
                        default: 
                        day -= 1;
                        break;
                    }
                    //Вивід готового
                    Console.WriteLine("{0}|{1}|{2}",day,mounth,year);

                }
            }

        }
    }
}