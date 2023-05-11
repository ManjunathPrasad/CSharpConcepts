namespace BaseKeyword.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            baseClass.Print();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Print();

            Console.ReadKey();  
        }
    }
}