using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_Practice_Task_1
{
    class Vector
    {
        public Vector(int x, int y, int z)
        {
            this.x = x ;
            this.y  = y ;
            this.z  = z ;

        }

        int x, y, z;

        public Vector Sum (Vector v1, Vector v2)
        {
            Vector Sum = new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
            
            return Sum;
        }

        public  Vector  Subtract(Vector v1, Vector v2)
        {
            Vector Substract = new Vector(v1.x - v2.x , v1.y - v2.y ,v1.z - v2.z  );
            return Substract;
        }

        public override string ToString()
        {
            return string.Format("x = {0}, y = {1} z = {2}", this.x, this.y, this.z);
        }


        /* public void ScalMultiplication()
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
         }*/
    }
}
