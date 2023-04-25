using System.Security.Cryptography.X509Certificates;

namespace Delegates.Demo
{
    public class Program
    {
        //note Delegate declaration
        delegate void Calculator(int x, int y);
        public static void Add(int a, int b)
        {
            Console.WriteLine($"{a + b}");
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine($"{a * b}");
        }
        public static void Main(string[] args)
        {
            //note Calling 'Mul' method with delegate 'Calculator' object instantiation
            Calculator calculator = new Calculator(Mul);

            calculator(10, 20);
        }
    }
}