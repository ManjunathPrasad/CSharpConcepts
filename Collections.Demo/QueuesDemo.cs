namespace Collections.Demo
{
    public class QueuesDemo
    {
        public void GetQueues ()
        {
            //Queues Demo
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Queues Demo");
            var queuesDemo = new Queue<string>();
            queuesDemo.Enqueue("Red");
            queuesDemo.Enqueue("Green");
            queuesDemo.Enqueue("Blue");
            queuesDemo.Enqueue("White");

            foreach (string c in queuesDemo)
            {
                Console.WriteLine(c);
            }

            var removedElement = queuesDemo.Dequeue();
            Console.WriteLine($"The Popped color is {removedElement}");
            Console.WriteLine($"Queue Head is at--> {queuesDemo.Peek()}");
            Console.ResetColor();
        }
    }
}