using System;
using System.Collections;

public class Quote
{

    // Private members are the details specified 
    private string Name;
    private string EmailAddress;
    private string DateOfBirth;
    private int CarYear;
    private string CarMake, CarModel;
    private bool hasDUI;
    private int NumSpeedTickets;
    private char CL;  // coverage 'c' or liability 'l'
    private bool didAsk;


    public Quote()
    {
        Name = "";
        EmailAddress = "";
        DateOfBirth = "";
        CarYear = 0;
        CarMake = "";
        CarModel = "";
        hasDUI = false;
        NumSpeedTickets = 0;
        CL = ' ';
        didAsk = false;
    }


    // Functions to ask for various things (everything will be private except for one)
    private void AskName()
    {
        Console.Write("Please enter your name:\n> ");
        Name = Console.ReadLine();
        Console.WriteLine();
    }

    private void AskEmailAddress()
    {
        // For a valid email address, it must have a @ and a . at minimum, and @ must occur before .
        Console.Write("Please enter your email address:\n> ");
        EmailAddress = Console.ReadLine();

        while (EmailAddress.IndexOf("@") == -1 || EmailAddress.IndexOf(".") == -1 || EmailAddress.IndexOf("@") > EmailAddress.IndexOf("."))
        {
            Console.Write("Please enter your email address: \n> ");
            EmailAddress = Console.ReadLine();
        }
        Console.WriteLine();
    }

    private void AskDateOfBirth()
    {
        // For a valid date of birth, it must follow the XX/XX/XXXX format exactly
        Console.Write("Please enter your date of birth (in the XX/XX/XXXX) format:\n> ");
        DateOfBirth = Console.ReadLine();

        // Be harsh about this condition: check one at a time
        // First check if the length is 10
        // Then check if indexes 2 and 5 contain a /
        // Then check if the rest of the indexes are numeric
        // If all 3 hold true, then our date format is correct
        // If even one do not hold true, then start over
        if (DateOfBirth.Length == 10)
        {
            bool validDate = true;
            for (int i = 0; i < 10; i++)
            {
                if (i == 2 || i == 5)
                {
                    if (DateOfBirth[i] != '/')
                    {
                        validDate = false;
                        break;
                    }
                }
                else
                {
                    if (!Char.IsNumber(DateOfBirth[i]))
                    {
                        validDate = false;
                        break;
                    }
                }
            }

            // If the date flag did not change to false, then we are done.  
            if (validDate)
            {
                Console.WriteLine();
                return;
            }
        }

        // If even one check is invalid, we have to start all over again
        AskDateOfBirth();
    }

    private void AskCarYear()
    {
        // For a valid car year, assume the make to be anywhere between 1800 and 2099
        // Just in case there's an erroneous input, we'll surround in a try/catch block

        try
        {
            Console.Write("Please enter your car year:\n> ");
            CarYear = Int32.Parse(Console.ReadLine());

            while (CarYear < 1800 || CarYear > 2099)
            {
                Console.Write("Please enter your car year:\n> ");
                CarYear = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine();
        }
        catch (FormatException)
        {
            // Invalid input, ask again
            AskCarYear();
        }
    }

    private void AskCarMakeModel()
    {
        // No error handling necessary here
        Console.Write("Please enter your car make:\n> ");
        CarMake = Console.ReadLine();

        Console.WriteLine();

        Console.Write("Please enter your car model here:\n> ");
        CarModel = Console.ReadLine();

        Console.WriteLine();
    }

    private void AskDUI()
    {
        // yes or no (y/n)
        Console.Write("Do you have a DUI? (y/n):\n> ");
        string answer = Console.ReadLine();

        while (answer.ToLower() != "y" && answer.ToLower() != "n")
        {
            Console.Write("Do you have a DUI? (y/n):\n> ");
            answer = Console.ReadLine();
        }

        Console.WriteLine();

        // Then, y means hasDUI = true, otherwise hasDUI = false
        if (answer.ToLower() == "y")
            hasDUI = true;
        else
            hasDUI = false;
    }

    private void AskSpeedTickets()
    {
        // try catch block in case error is erroneous

        try
        {
            Console.Write("How many speeding tickets do you have?\n> ");
            NumSpeedTickets = Int32.Parse(Console.ReadLine());

            // A valid input means the # of speeding tickets must at least be 0
            while (NumSpeedTickets <= -1)
            {
                Console.Write("How many speeding tickets do you have?\n> ");
                NumSpeedTickets = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine();
        }
        catch (FormatException)
        {
            AskSpeedTickets();
        }
    }

    private void AskCLQuestion()
    {
        Console.Write("Would you like full coverage or liability? (c/l):\n> ");
        CL = Char.ToLower(Console.ReadLine()[0]);

        while (CL != 'c' && CL != 'l')
        {
            Console.Write("Would you like full coverage or liability? (c/l):\n> ");
            CL = Char.ToLower(Console.ReadLine()[0]);
        }

        Console.WriteLine();
    }

    // One of two non-private method functions
    // Simply asks the questions from above
    public void AskQuestions()
    {

        // Call all the asking functions defined above
        AskName();
        AskEmailAddress();
        AskDateOfBirth();
        AskCarYear();
        AskCarMakeModel();
        AskDUI();
        AskSpeedTickets();
        AskCLQuestion();

        // Change the didAsk flag to true
        didAsk = true;
    }


    // One of two non-private method functions
    // Computes the total cost after calling the methods above
    public double CalculateTotal()
    {

        if (!didAsk)
        {
            Console.WriteLine("Please ask the questions before computing the total");
            return 0;
        }

        // Now calculate the total, starting at a minimum of 50
        double total = 50;

        // First, compute the age (in years):
        // subtract the current year (2020) from the person's date of birth (year begins at index 6)
        int age = 2020 - Int32.Parse(DateOfBirth.Substring(6));
        Console.WriteLine("Age: " + age);

        // If the user's age is under 18, add 100 to the total 
        if (age < 18)
            total += 100;

        // If the user's age is under 25 (but now at least 18 years)
        // also applies if the user's age is over 100
        else if (age < 25 || age > 100)
            total += 25;


        // Second, deal with the car's year

        // If the car year is before 2000 or after 2015, add 25 to the total
        Console.WriteLine("Car year: " + CarYear);
        if (CarYear < 2000 || CarYear > 2015)
            total += 25;

        // Because the app hates Porsches and 911 Carrera, we'll deal with these sequentially
        Console.WriteLine("Car make: " + CarMake + "\nCar model: " + CarModel);
        if (CarMake.ToLower() == "porsche")
        {

            // If the car make is a porsche, add 25
            total += 25;

            // Additionally, if the car model is a 911 Carrera, add another 25 to the total
            if (CarModel.ToLower() == "911 carrera")
                total += 25;
        }

        // Add 10 x # of speeding tickets to the total 
        Console.WriteLine("# of speeding tickets: " + NumSpeedTickets);
        total += 10 * NumSpeedTickets;

        // If the user has a DUI, add 25%
        Console.WriteLine("Does this person have DUI: " + hasDUI);
        if (hasDUI)
            total += (total * 0.25);

        // If the user has full coverage, add 50%
        Console.WriteLine("Type of coverage: " + CL);
        if (CL == 'c')
            total += (total * 0.5);

        // Finished, return the total
        return total;
    }
}

public class QuoteApplication
{

    public static void Main()
    {

        ArrayList QuoteList = new ArrayList();

        while (true)
        {
            char answer;
            Console.Write("Would you like to add a quote? (y/n):\n> ");
            answer = Char.ToLower(Console.ReadLine()[0]);
            while (answer != 'y' && answer != 'n')
            {
                Console.Write("Would you like to add a quote? (y/n):\n> ");
                answer = Char.ToLower(Console.ReadLine()[0]);
            }
            if (answer == 'n')
            {
                Console.WriteLine();
                break;
            }

            Quote newQuote = new Quote();
            newQuote.AskQuestions();
            Console.WriteLine("Here is the total cost from this quote: $" + Math.Round(newQuote.CalculateTotal(), 2) + "\n");
            QuoteList.Add(newQuote);
        }

        // We're finished
        Console.WriteLine("No more quotes for the day, here is how many you have written: " + QuoteList.Count);
    }
}

