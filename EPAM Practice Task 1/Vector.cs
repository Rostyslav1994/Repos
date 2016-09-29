using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_Practice_Task_1
{

    class Vector

    {
        public int[] a = new int[3] { 3, 4, 5 };
        public int[] b = new int[3] { 4, 4, 2 };
        public int[] i = new int[3];
        public int  ScalMult;
        public double Len_a;
        public double Len_b;
        public double ang_ab;



        public int[]Sum(int[]a , int[]b)
        {
            int[] Sum = new int[3];
            Sum[0] = a[0] + b[0];
            Sum[1] = a[1] + b[1];
            Sum[2] = a[2] + b[2];
            return Sum  ;
            

        }

        public void Subtract()
        {
            int[] Subtract = new int[3];
            Subtract[0] = a[0] - b[0];
            Subtract[1] = a[1] - b[1];
            Subtract[2] = a[2] - b[2];

            Console.WriteLine("Vector a - b = c({0},{1},{2})", Subtract[0], Subtract[1], Subtract[2]);

        }

        public void ScalMultiplication()
        {
            int ScalMultiplication;
            int[] Multiplication = new int[3];
            Multiplication[0] = a[0] * b[0];
            Multiplication[1] = a[1] * b[1];
            Multiplication[2] = a[2] * b[2];

            ScalMultiplication = Multiplication[0] + Multiplication[1] + Multiplication[2];
            ScalMult = ScalMultiplication;

            Console.WriteLine("ScalMultiplication Vectors a & b = {0}", ScalMultiplication);
            
        }

        public void VectlMultiplication()
        {
            int[] VectMultiplication = new int[3];
            VectMultiplication[0] =  (a[1] * b[2] - a[2] * b[1]);
            VectMultiplication[1] = -(a[0] * b[2] - a[2] * b[0]);
            VectMultiplication[2] = +(a[0] * b[1] - a[1] * b[0]);
            i[0] = VectMultiplication[0];
            i[1] = VectMultiplication[1];
            i[2] = VectMultiplication[2];

            Console.WriteLine("VectlMultiplication a & b = i({0},{1},{2})", VectMultiplication[0], VectMultiplication[1], VectMultiplication[2]);
            

        }
        public void  Length_a()
        {
            int   Mult = a[0] * a[0] + a[1] * a[1] + a[2] * a[2];
            double  LV = (Math.Sqrt(Mult));
            Len_a = LV;

            Console.WriteLine("Length of Vector a = {0}", LV );
        }

        public void Length_b()
        {
            int   Mult = b[0] * b[0] + b[1] * b[1] + b[2] * b[2];
            double LV = Math.Sqrt(Mult);
            Len_b = LV;

            Console.WriteLine("Length of Vector b = {0}", LV);
        }


        public void Angle()
        {
            double angle = ScalMult / (Len_a * Len_b);
            ang_ab = angle;

            Console.WriteLine("Angle of Vectors a & b = {0}",angle );
            
        }
    }
    


}
