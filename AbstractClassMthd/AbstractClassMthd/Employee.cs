namespace AbstractClassMthd
{
    public class Employee : Person
    {
        public override void SayName()
        {
            System.Console.WriteLine("Your pseudo name is: {0} {1}", firstName, lastName);
        }
    }
}
