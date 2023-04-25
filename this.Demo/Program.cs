namespace This.Demo;
internal class Program
{
    static void Main(string[] args)
    {
        Guid guid = Guid.NewGuid(); 
        Student student = new Student(guid);
    }
    public class Student
    {
        private Guid id;
        public Student(Guid id) 
        {
            //note There are two ids' one is constructor parameter and other is local field. Hence this keyword is used to refer to the current instance(local field) of the class 
            
            this.id = id;
            Console.WriteLine(this.id);
        }
    }
}
