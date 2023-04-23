namespace Collections.Demo
{
    public class HaslistDemo
    {
        public void GetHashLists ()
        {
            /*
             * HashSet doesn't include duplicated values. For example, in the below code, "Tokyo" was duplicated twice, however the output has only one "Tokyo"
             */
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Demo of Hash list");


            var city = new HashSet<string>();

            city.Add("Tokyo");
            city.Add("Oslo");
            city.Add("Tokyo");
            city.Add("Los Angeles");
            foreach (string c in city)
            {
                Console.WriteLine(c);
            }
            Console.ResetColor();

        }
    }
}