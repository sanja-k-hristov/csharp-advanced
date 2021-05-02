using System;

namespace WorkDay
{
    class Program
    {
        static void Main(string[] args)
        {
                string answer = "";

                while (answer != "NO")
                {
                  
                    Console.WriteLine("Enter your date to check if it is working day or not, in the following format DD-MM-YYYY");

                    string userInput = Console.ReadLine();
                    bool tryParseDate = DateTime.TryParse(userInput, out DateTime parsedDate);

                    if (tryParseDate == true)
                    {
                        if ((parsedDate.Day == 1 && parsedDate.Month == 1) || (parsedDate.Day == 7 && parsedDate.Month == 1) || (parsedDate.Day == 20 && parsedDate.Month == 4) || (parsedDate.Day == 1 && parsedDate.Month == 5) || (parsedDate.Day == 25 && parsedDate.Month == 5) || (parsedDate.Day == 3 && parsedDate.Month == 8) || (parsedDate.Day == 8 && parsedDate.Month == 9) || (parsedDate.Day == 12 && parsedDate.Month == 10) || (parsedDate.Day == 23 && parsedDate.Month == 10) || (parsedDate.Day == 8 && parsedDate.Month == 12) || parsedDate.DayOfWeek == DayOfWeek.Saturday || parsedDate.DayOfWeek == DayOfWeek.Sunday)
                        {
                            Console.WriteLine($"You entered: {parsedDate} - non-working day");
                        }
                        else
                        {
                            Console.WriteLine($"You entered: {parsedDate} - working day");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again...");
                    }
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Do u want to continue(YES/NO):");
                    answer = Console.ReadLine().ToUpper();
                    Console.Clear();
                }   
        }
    }
}
