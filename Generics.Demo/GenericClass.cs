namespace Generics.Demo
{
    public class GenericClass<T>
    {
        private string? message = "Hi";
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }

        }

        public void GetMessage()
        {
            Console.WriteLine(message);
        }
    }
}