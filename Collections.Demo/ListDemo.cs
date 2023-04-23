namespace Collections.Demo
{
    public class ListDemo
    {
        public void GetList ()
        {
            List<string> country = new List<string>();

            country.Add("Japan");
            country.Add("Norway");
            country.Add("Belgium");
            country.Add("Japan");

            Console.WriteLine("Demo of List");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("List of Countries");

            foreach (string s in country)
            {
                Console.WriteLine(s);
            }
            Console.ResetColor();

        }
    }
}