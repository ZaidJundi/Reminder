using Reminder2;

Class1 reminder = new Class1();
DateTime currentDateTime = DateTime.Now;

while (true)
{
    Console.Write("Add Date (dd-MM-yyyy HH:mm:ss): ");
    string inputDate = Console.ReadLine();

    if (DateTime.TryParseExact(inputDate, "dd-MM-yyyy HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime inputDateTime))
    {
        if (inputDateTime > currentDateTime)
        {
            Console.Write("Add Message: ");
            string message = Console.ReadLine();

            while (inputDateTime > currentDateTime)
            {
                currentDateTime=DateTime.Now;

            }

            Console.WriteLine($"Reminder: Date - {inputDateTime.ToString("dd-MM-yyyy HH:mm:ss")}, Message - {message}");
        }
        else if (inputDateTime < currentDateTime)
        {
            Console.WriteLine($"Error: The input date and time is in the past: {inputDateTime.ToString("dd-MM-yyyy HH:mm:ss")}");
        }
        else
        {
            Console.WriteLine("The entered date and time is the same as the Reminder date and time.");
        }
    }
    else
    {
        Console.WriteLine("Invalid date and time format.");
    }

    Console.WriteLine("Do you want to add a new Reminder? (Y/N)");
    string input = Console.ReadLine();

    if (input.Equals("N", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Exiting the reminder system...");
        break;
    }
    else if (!input.Equals("Y", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Invalid input. Please enter Y or N.");
    }
}