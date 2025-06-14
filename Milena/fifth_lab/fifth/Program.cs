using System;

namespace fifth{
    public class Stud_Sessiya{
        public void ShowMarks(){
            Console.WriteLine(" ");
            Console.WriteLine("Math mark: {0}",MathAnalisys);
            Console.WriteLine("Programming basics: {0}",Op);
            Console.WriteLine("Phisics mark: {0}",Phisics);
            Console.WriteLine("English mark: {0}",Engish);
            Console.WriteLine("Pakety mark: {0}",Pakety);
            Console.WriteLine("Ukr Mova mark: {0}",Ukr_Mova);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Math mark: {0}",M);
            Console.WriteLine("Programming basics: {0}",P);
            Console.WriteLine("Phisics mark: {0}",F);
            Console.WriteLine("English mark: {0}",E);
            Console.WriteLine("Pakety mark: {0}",W);
            Console.WriteLine("Ukr Mova mark: {0}",U);
            Console.WriteLine(" ");

        }
        public void FiveMark(){
            if(Op<60){
                P = 2;
            }else if(Op>=60 && Op<74){
                P = 3;
            }else if(Op>74 && Op<89){
                P = 4;
            } else {
                P = 5;
            }

            if(MathAnalisys<60){
                M = 2;
            }else if(MathAnalisys>=60 && MathAnalisys<74){
                M = 3;
            }else if(MathAnalisys>74 && MathAnalisys<89){
                M = 4;
            } else {
                M = 5;
            }

            if(Phisics<60){
                F = 2;
            }else if(Phisics>=60 && Phisics<74){
                F = 3;
            }else if(Phisics>74 && Phisics<89){
                F = 4;
            } else {
                F = 5;
            }

            if(Engish<60){
                E = 2;
            }else if(Engish>=60 && Engish<74){
                E = 3;
            }else if(Engish>74 && Engish<89){
                E = 4;
            } else {
                E = 5;
            }

            if(Pakety<60){
                W = 2;
            }else if(Pakety>=60 && Pakety<74){
                W = 3;
            }else if(Pakety>74 && Pakety<89){
                W = 4;
            } else {
                W = 5;
            }

            if(Ukr_Mova<60){
                U = 2;
            }else if(Ukr_Mova >=60 && Ukr_Mova<74){
                U = 3;
            }else if(Ukr_Mova>74 && Ukr_Mova<89){
                U = 4;
            } else {
                U = 5;
            }

            
            
        }

        public void Ser(){
            bool passion;
            if(Op < 60 || MathAnalisys < 60 || Phisics < 60 || Engish < 60 || Pakety < 60 || Ukr_Mova < 60){
                passion = false;
            }else {
                passion = true;
            }
            int s = (Op + MathAnalisys + Phisics + Engish + Pakety + Ukr_Mova)/6;
            Console.WriteLine("Arifmetic Average of all marks is {0}",s);
            int ss = (M+P+F+E+W+U)/6;
            Console.WriteLine("Arifmetic Average of marks in 5 bal system is {0}",ss);
            Console.WriteLine("Student passed exams: {0}",passion);

        }
        

        public Stud_Sessiya(int M, int P, int F, int E, int W, int U ){
            MathAnalisys = M;
            Op = P;
            Phisics = F;
            Engish = E;
            Pakety = W;
            Ukr_Mova = U;
        }
        public int MathAnalisys;
        public int Op;
        public int Phisics;
        public int Engish;
        public int Pakety;
        public int Ukr_Mova;
        public int M;
        public int P;
        public int F;
        public int E;
        public int W;
        public int U;

    }
    class Program{
        static void Main(string[] args){
            Stud_Sessiya s = new Stud_Sessiya(60,70,45,60,80,50);
            
            s.FiveMark();

            s.ShowMarks();

            s.Ser();

        }
    }
}