using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace Collections.Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListDemo listDemo = new ListDemo();
            listDemo.GetList();
            Console.ReadKey();
            Console.Clear();

            HaslistDemo haslistDemo = new HaslistDemo();
            haslistDemo.GetHashLists();
            Console.ReadKey();
            Console.Clear();    

            StacksDemo stacksDemo = new StacksDemo();
            stacksDemo.StackList();
            Console.ReadKey();
            Console.Clear();

            QueuesDemo queuesDemo = new QueuesDemo();   
            queuesDemo.GetQueues();
            Console.ReadKey();
            Console.Clear();

        }
    }
}