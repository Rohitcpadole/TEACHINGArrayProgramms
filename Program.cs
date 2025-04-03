using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramms
{
    class Program
    {
        static void Main(string[] args)
        {
            /////Array
            /////User Defined Datatype to store similar maultiple values
            /////Single Dimension Array
            /////Synatx:
            /////Arrayt Declartion of size 3
            //int[] age = new int[3];
            /////How to Insert Values in Array
            /////Type:1: Add values to age array
            //Console.WriteLine("Type 1 Array ");
            //age[0] = 56;
            //age[1] = 89;
            //age[2] = 57;
            //for (int i = 0; i <= 2; i++)
            //{
            //    Console.WriteLine("Age="+age[i]);
            //}
            /////Type:2 Add Values to Age Array
            //Console.WriteLine("Type 2 Array");
            //int[] marks = { 45, 89, 56, 78, 56, 56 };//Having size 6
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine("Marks="+marks[i]);
            //}
            /////Type:3 Add USer values to array
            //Console.WriteLine("Type 3 Array");
            //Console.WriteLine("Please Enter Ages");
            //int[] weights = new int[5];
            //for (int i=0;i< weights.Length; i++)
            //{
            //    weights[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < weights.Length; i++)
            //{
            //    Console.WriteLine("Weights=" + weights[i]);
            //}
            Console.WriteLine("----------------------------------------------------------------");
            
            string[] name = new string[100];
            int[] rollno = new int[100];
            double[] percentage = new double[100];
            int id;
            Console.Write("how Many Id's You Need :");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Name :");
            Console.WriteLine("Enter a Roll No. :");
            Console.WriteLine("Enter a Percentage :");


            for (int i=0;i<id;i++)
            {
                Console.WriteLine();
                Console.WriteLine("Please Enter Next :");
                name[i] =Convert.ToString( Console.ReadLine());
                rollno[i] = Convert.ToInt32(Console.ReadLine());
                percentage[i] = Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine("--------------------------Id--------------------------");
            for(int i=0;i<id;i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Name = "+name[i]);
                Console.WriteLine("Rollno. = "+rollno[i]);
                Console.WriteLine("Percentage ="+percentage[i]+"%");
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
