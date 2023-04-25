using System.Security.Cryptography.X509Certificates;

namespace OutRef.Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 2000;
             OutRef outRef = new OutRef();  

            int result = outRef.Add(out a, ref b);
            Console.WriteLine(a + b);
            Console.WriteLine(result);
            Console.ReadLine();
            
        }
    }
}