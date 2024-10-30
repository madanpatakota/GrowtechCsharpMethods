using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


//sequence or step by step
namespace SequentailWorkItemDevelopers
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
            var startTime =  DateTime.Now;

            Thread.Sleep(2000); // 2 secs

            var endTime   = DateTime.Now;   

            var diffTime = endTime - startTime;

            Console.WriteLine($"Completed the Task for Shashank and his time :{ diffTime}"); // 2 secs
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
        public static void TypescriptWorkItem() {
           
                var startTime = DateTime.Now;

                Thread.Sleep(5000); // 3 secs

                var endTime = DateTime.Now;

                var diffTime = endTime - startTime;

                Console.WriteLine($"Completed the Task for Siva and his time :{diffTime}");
            
        }

    }

    //F10 and F11
    class DeveloperAssignments
    {
        public static void Main() {
            /*****************For sequential order******************/
            Console.WriteLine("Sequential Downloading:");

            var sequentialStartTime = DateTime.Now; // Calculate time
            //14 secs |  5 secs | 14 secs
            WorkItems.JavascriptWorkItem(); // 2 secs
            WorkItems.CsharpWorkItem();     // 
            WorkItems.AngularWorkItem();
            WorkItems.TypescriptWorkItem();

            var sequentialEndTime = DateTime.Now;

            var diffOfsequentialTime = sequentialEndTime - sequentialStartTime;
            Console.WriteLine($"All Developers Related Task has completed and Total time has taken the - {diffOfsequentialTime}"); // Expected time.

            Console.ReadLine();

        }
    }
}
