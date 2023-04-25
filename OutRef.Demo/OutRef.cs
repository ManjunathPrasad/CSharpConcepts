namespace OutRef.Demo
{
    public class OutRef
    {
        int number1;   
        int number2 = 0;

        public int Add (out int number1, ref int number2)
        {
            number1 = 50;
            return number1 + number2;
        }
    }
}