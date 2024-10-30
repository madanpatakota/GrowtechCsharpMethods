using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Target : Execute all tasks at the same time.
//The async and await keywords in C# are used to work with asynchronous programming. Asynchronous programming allows you to perform operations concurrently without blocking the main thread of your application....


// await - waiting.
//In Await section we will be wait uptot get the response.

// he said that 2 mins. 


namespace AsyncAwaitWorkItemDevelopers
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
        async static Task Main()
        {
            //int x =  DeveloperAssignments.empid();
            Task taskShashank = DeveloperAssignments.ShashankWorkItem();
            Task taskKarthik = DeveloperAssignments.KarthikWorkItem();
            Task taskKeerthi = DeveloperAssignments.KeerthiWorkItem();
            Task taskSiva = DeveloperAssignments.SivaWorkItem();

            /**********For based on the Tasks ***********/
            var taskStartTime = DateTime.Now;
            //
            await Task.WhenAll(taskShashank, taskKarthik, taskKeerthi, taskSiva);

            var taskEndTime = DateTime.Now;

            //Diff

            var diffTime = taskEndTime - taskStartTime;

            Console.WriteLine($" All Developers Related Task has completed and Total time has taken the  {diffTime}");

            Console.ReadLine();


        }
    }
}
