namespace Collections.Demo
{
    public class StacksDemo
    {
        public void StackList ()
        {
            // Stacks Demo
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Demo of Stacks");

            var colors = new Stack<string>();

            colors.Push("Red");
            colors.Push("Green");
            colors.Push("Blue");

            foreach (string c in colors)
            {
                Console.WriteLine(c);
            }

            var popColor = colors.Pop();
            Console.WriteLine($"The Popped color is {popColor} \n");
            Console.ResetColor();
        }
    }
}