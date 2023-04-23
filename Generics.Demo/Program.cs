namespace Generics.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> a = new GenericClass<int>();
            GenericClass<string> b = new GenericClass<string>();
            GenericClass <double> genericClass = new GenericClass<double>();

            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
           
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(b.Message);
            Console.WriteLine(genericClass.Message);
        }
    }
}