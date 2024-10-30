using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Target : Execute all tasks at the same time.
namespace ParllelWorkItemDevelopers
{
    class Developer
    {
        public string name;
        public string workName;
        public int time;
    }
    class WorkItems
    {
        public static void JavascriptWorkItem()
        {
            var startTime = DateTime.Now;

            Thread.Sleep(2000); // 2 secs

            var endTime = DateTime.Now;

            var diffTime = endTime - startTime;

            Console.WriteLine($"Completed the Task for Shashank and his time :{diffTime}"); // 2 secs
        }
        public static void CsharpWorkItem()
        {
            var startTime = DateTime.Now;

            Thread.Sleep(3000); // 3 secs

            var endTime = DateTime.Now;

            var diffTime = endTime - startTime;

            Console.WriteLine($"Completed the Task for Karthik and his time :{diffTime}");
        }
        public static void AngularWorkItem()
        {
            var startTime = DateTime.Now;

            Thread.Sleep(4000); // 4 secs

            var endTime = DateTime.Now;

            var diffTime = endTime - startTime;

            Console.WriteLine($"Completed the Task for Keerthi and his time :{diffTime}");
        }
        public static void TypescriptWorkItem()
        {

            var startTime = DateTime.Now;

            Thread.Sleep(5000); // 3 secs

            var endTime = DateTime.Now;

            var diffTime = endTime - startTime;

            Console.WriteLine($"Completed the Task for Siva and his time :{diffTime}");

        }

    }

    class DeveloperAssignments
    {
        public static Task ShashankWorkItem()
        {
            return Task.Run(() =>
            {
                WorkItems.JavascriptWorkItem();
            });
        }
        public static Task KarthikWorkItem()
        {
            return Task.Run(() =>
            {
                WorkItems.CsharpWorkItem();
            });
        }
        public static Task KeerthiWorkItem()
        {
            return Task.Run(() =>
            {
                WorkItems.AngularWorkItem();
            });
        }
        public static Task SivaWorkItem()
        {
            return Task.Run(() =>
            {
                WorkItems.TypescriptWorkItem();
            });
        }

        public static int empid()
        {
            return 10;
        }
    }

    //async await
    class Program
    {
        public static void Main()
        {
            //int x =  DeveloperAssignments.empid();
            Task taskShashank =  DeveloperAssignments.ShashankWorkItem();
            Task taskKarthik =   DeveloperAssignments.KarthikWorkItem();
            Task taskKeerthi =   DeveloperAssignments.KeerthiWorkItem();
            Task taskSiva    =   DeveloperAssignments.SivaWorkItem();

            /**********For based on the Tasks ***********/
            var taskStartTime = DateTime.Now;
            //
            Task.WhenAll(taskShashank, taskKarthik, taskKeerthi, taskSiva).Wait();

            var taskEndTime = DateTime.Now;

            //Diff

            var diffTime = taskEndTime - taskStartTime;

            Console.WriteLine($" All Developers Related Task has completed and Total time has taken the  {diffTime}");

            Console.ReadLine();


        }
    }


    //F10 and F11
    //class DeveloperAssignments
    //{
    //    //Running race....runners start the game same time.
    //    public static void Main()
    //    {
    //        /*****************For sequential order******************/
    //        Console.WriteLine("Sequential Downloading:");

    //        var sequentialStartTime = DateTime.Now; // Calculate time


    //        WorkItems.JavascriptWorkItem(); // 2 secs
    //        WorkItems.CsharpWorkItem();     // 
    //        WorkItems.AngularWorkItem();
    //        WorkItems.TypescriptWorkItem();

    //        var sequentialEndTime = DateTime.Now;

    //        var diffOfsequentialTime = sequentialEndTime - sequentialStartTime;
    //        Console.WriteLine($"All Developers Related Task has completed and Total time has taken the - {diffOfsequentialTime}"); // Expected time.

    //        Console.ReadLine();

    //    }
    //}
}
