namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
        }
    }
}
