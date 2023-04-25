namespace Params.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 50; //note Always initialize ref variable
            int y = Add(ref a, 10, 20, 30, 40, 50);

            Console.WriteLine(y);
           
        }
        //note Use params keyword in the parameters, when we do not know how many parameters are going to get passed 
        //note params must be last parameter within the function call
        public static int Add(ref int x, params int[] numbersList)
        {
            int total = 0;

            foreach (int number in numbersList)
            {
                total += number;

            }
            return total;
        }
    }
}