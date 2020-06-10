using System;

class EDays
{
    enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    public static void Main()
    {

        try
        {
            Console.WriteLine("What day is it today?:");           
            string day = Console.ReadLine();
            day = char.ToUpper(day[0]) + day.Substring(1);

            Days ValidInput;
            switch (day)
            {
                case "Sunday":
                    ValidInput = Days.Sunday;
                    break;

                case "Monday":
                    ValidInput = Days.Monday;
                    break;

                case "Tuesday":
                    ValidInput = Days.Tuesday;
                    break;

                case "Wednesday":
                    ValidInput = Days.Wednesday;
                    break;

                case "Thursday":
                    ValidInput = Days.Thursday;
                    break;

                case "Friday":
                    ValidInput = Days.Friday;
                    break;

                case "Saturday":
                    ValidInput = Days.Saturday;
                    break;

                default:
                    throw new Exception("Enter the actual day of the week.");
            }

            Console.WriteLine("Today is " + ValidInput.ToString() + ".");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            
        }
    }
}