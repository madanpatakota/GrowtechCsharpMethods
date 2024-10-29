using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpMethods
{
    class Method_returntype
    {
        //void method - Non return type methods

        // understand diff b/w defination and calling 

        // always main method executes . no execuses
        public static void Main()
        {

            //double piVlue = 3.17;
            //if(piVlue == 3.17)
            //{
            //}
            //else
            //{

            //}
           string status = Method_returntype.getEmpStatus(); // 3+ Exp
           Console.WriteLine(status);

            Method_returntype.PrintMessage();

            Console.ReadLine();



        }
        public static void PrintMessage()
        {
            
            Console.WriteLine("Calling PrintMessage Method");
        }
        public static void PrintCalculateAddtion()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("Addition is a and b is I.e.", a + b);
        }
        public static int getTotalValue()
        {
            int a = 10;
            int b = 20;
            return a + b;
        }
        //Always think what is the input and what is the return type
        public static int[] getSomeNumbers()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            int a = 10;

            return numbers;
        }
        public static string getEmpStatus()
        {
            string studentName = "Siva";
            
            if (studentName == "Keerthi")
            {
                return "Fresher";
            }
            else
            {
                return "3+ Exp";
            }
        }



    }
}
