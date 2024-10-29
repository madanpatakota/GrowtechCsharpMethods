using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpMethods
{
    //void method - Non return type methods
    // understand diff b/w defination and calling 
    // always main method executes . no execuses
    //Always think what is the input and what is the return type
    class Methods_Inputs
    {
        public static void Main()
        {
            //Methods_Inputs.Student1Details("Madan" , "C#.net");

            //Methods_Inputs.Student3Details("Madan" , "Angular");

            //i want to pass multiple arguments
            Methods_Inputs.SivaDetails("Siva", "Angular" , "He is from TamilNadu" ,"He is in Bangolore");

            Console.ReadLine();
        }

        //Parameters
        static void KeerthiDetails(string name , string CourseName)
        {
            Console.WriteLine(name);
            Console.WriteLine(CourseName);
        }

        static void ShashankDetails(string name, string CourseName)
        {
            //$"{}"
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {CourseName}");
        }

        static void KarthikDetails(string name, string CourseName = "No Course")
        {
            //$"{}"
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"CourseName: {CourseName}");
        }

        static void SivaDetails(string name,string CourseName, params string[] details)
        {
            //
            Console.WriteLine(name);
            Console.WriteLine(CourseName);

            for(int index =0; index< details.Length;index = index + 1)
            {
                Console.WriteLine(details[index]);
            }
            

        }


        //All the methods i have taken the void

        //Home work : Prepare non-void methods 

    }
}
