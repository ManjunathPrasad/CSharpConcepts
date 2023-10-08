namespace Inheritance.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Restaurant!");

            Chef chef = new Chef(); 

            chef.BakeChicken();
            chef.MakeSalad();
            chef.ChefSpecial();

            ItalianChef italianChef = new ItalianChef();
            italianChef.BakeChicken();

        }
    }
}