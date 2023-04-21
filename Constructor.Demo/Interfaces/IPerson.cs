namespace Constructor.Demo.Interfaces
{
    public interface IPerson
    {
        string? FirstName { get; set; }
        string? FullName { get; set; }
        static Guid IdentificationNumber { get; set; }
        string? LastName { get; set; }
        Address? Location { get; set; }

        void PrintGuid();
    }
}