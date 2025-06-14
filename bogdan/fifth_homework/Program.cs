using System;

namespace fifth_homework{

    public class Vector_3D{
        double x,y,z;
        //double x1,y2,y3;

        public Vector_3D(double a, double b, double c){
            x = a;
            y = b;
            z = c;
        }

        public static Vector_3D operator +(Vector_3D a,Vector_3D b){
            Vector_3D temp = new Vector_3D(a.x + b.x, a.y + b.y, a.z + b.z);
            return temp; 
        }

        public static Vector_3D operator -(Vector_3D a,Vector_3D b){
            Vector_3D temp = new Vector_3D(a.x - b.x, a.y - b.y, a.z - b.z);
            return temp;
        }

        public static Vector_3D operator -(Vector_3D a){
            Vector_3D temp = new Vector_3D(a.x * (-1), a.y * (-1), a.z * (-1));
            return temp;
        }

        public static Vector_3D operator *(Vector_3D a, double i){
            Vector_3D temp = new Vector_3D(a.x * i, a.y * i, a.z * i);
            return temp;
        }

        public static double operator *(Vector_3D a, Vector_3D b){
            double temp = (a.x * b.x + a.y * b.y + a.z * b.z);
            return temp;
        }

        public void output(){
            Console.WriteLine("({0}, {1}, {2})",x , y, z);
        }

    }
    class Program{
        static void Main(string[] args){
            Vector_3D V = new Vector_3D(876 , -158, 256);

            V.output();

            Vector_3D W = new Vector_3D(-56,78,-204);

            Vector_3D Q = V + W;
            Q.output();

            Q = V * 43.9;
            Q.output();

            Q = -V;
            Q.output();

            double i = V * W;
            Console.WriteLine("{0}",i);
            Console.WriteLine();

            

            
        }
    }
}
