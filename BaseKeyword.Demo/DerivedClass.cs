namespace BaseKeyword.Demo
{
    public class DerivedClass : BaseClass
    {
        public override void Print ()
        {
            base.Print();
            Console.WriteLine("Derived Class Print Method");
        }
    }
}