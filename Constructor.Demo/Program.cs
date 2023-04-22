using Constructor.Demo.WorksAs;

namespace Constructor.Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Class");

            //Calling Default Constructor
            Person person = new Person();
            person.PrintGuid();

            //Calling Parameterized constructor
            Person emily = new Person(Guid.NewGuid(), "Emily","Bronte");
            emily.PrintGuid();

            //Overloading Constructor with different parameter types
            Person ernest = new Person("Ernest", "Hemingway", "Ernest Hemingway");
            ernest.PrintGuid();

            /*-----------------<Inheritance/interface>----------------*/
            Engineer Steve = new Engineer();
            Steve.PrintGuid();
            Steve.GetWorkDuration();
            Console.WriteLine(Person.IdentificationNumber);

            SoftwareEngineer Bill = new SoftwareEngineer();
            Bill.UpdateWorkDuration();
        }
    }
}