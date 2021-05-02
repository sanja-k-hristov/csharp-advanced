using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            int userWin = 0;
            int computerWin = 0;

            Console.WriteLine("Welcome to RPS game");

            while (answer != "NO")
            {
                Console.WriteLine("ROCK , PAPER or SCISSOR");
                string[] choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };
                Random rnd = new Random();
                int n = rnd.Next(0, 3);
                Console.WriteLine("Enter your choice:");
                string userChoice = Console.ReadLine().ToUpper();
                Console.WriteLine("Computer:" + choices[n]);

                if (userChoice == "ROCK" && choices[n] == "SCISSOR")
                {
                    Console.WriteLine("User wins");
                    userWin += 1;
                }
                else if (userChoice == "ROCK" && choices[n] == "PAPER")
                {
                    Console.WriteLine("Computer wins");
                    computerWin += 1;
                }
                else if (userChoice == "PAPER" && choices[n] == "ROCK")
                {
                    Console.WriteLine("User wins");
                    userWin += 1;
                }
                else if (userChoice == "PAPER" && choices[n] == "SCISSOR")
                {
                    Console.WriteLine("Computer Wins");
                    computerWin += 1;
                }
                else if (userChoice == "SCISSOR" && choices[n] == "ROCK")
                {
                    Console.WriteLine("Computer Wins");
                    computerWin += 1;
                }
                else if (userChoice == "SCISSOR" && choices[n] == "PAPER")
                {
                    Console.WriteLine("User wins");
                    userWin += 1;
                }
                else
                {
                    Console.WriteLine("Same choices");
                }
                Console.WriteLine("Do u want to continue(YES/NO):");
                answer = Console.ReadLine().ToUpper();
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("User wins " + userWin + " times");
            Console.WriteLine("Computer wins " + computerWin + " times");
        }
    }
}
