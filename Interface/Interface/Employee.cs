using Interface;

namespace Interface
{
    public class Employee : IQuittable
    {
          public void Quit()
        {
            System.Console.WriteLine("Never quit");
        } 
    }
}
