using System.Runtime.InteropServices;

namespace Number_Analyzer_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Here's where I'm preparing the user for the program.

            Console.Write("Greetings, User. What should I call you? ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Alright, {userName}. Let's get started.");

         

            while (true) // This is what makes the whole thing loop around.
            {
                int userNumber;
                while (true)
                {
                    Console.Write("Please enter an integer between 1 and 100, inclusive: ");
                    string userInput = Console.ReadLine();
                    if (int.TryParse(userInput, out userNumber)) // Now I'm actually going to make sure they put in a valid number.
                    {
                        if (userNumber >= 100)
                        {
                            Console.WriteLine($"Almost, {userName}. That is an integer, but it is not valid. Try again.");
                            continue;
                        }
                        break;
                    }
                    Console.WriteLine($"That is not an integer, {userName}. Do better."); 
                }

                // Now here's where I do the zillion different tests.

                if (userNumber < 60 && userNumber % 2 == 1)
                {
                    Console.WriteLine($"{userNumber} is odd and less than 60.");
                }
                else if (userNumber >= 2 && userNumber <= 24 && userNumber % 2 == 0)
                {
                    Console.WriteLine($"{userNumber} is even and less than 25.");
                }
                else if (userNumber >= 26 && userNumber <= 60 && userNumber % 2 == 0)
                {
                    Console.WriteLine($"{userNumber} is even and between 26 and 60, inclusive.");
                }
                else if (userNumber > 60 && userNumber % 2 == 0)
                {
                    Console.WriteLine($"{userNumber} is greater than 60 and even.");
                }
                else if (userNumber > 60 && userNumber % 2 == 1)
                {
                    Console.WriteLine($"{userNumber} is greater than 60 and odd.");
                }

                // This is where I ask if they want to try again.
                
                bool goAgain = true;
                while (true)
                {
                    Console.WriteLine($"That was pretty fun, {userName}. Do you want to analyze another number? Enter Y or N: ");
                    string userResponse = Console.ReadLine();

                    if (userResponse == "Y")
                    {
                        goAgain = true;
                        break;
                    }
                    else if (userResponse == "N")
                    {
                        goAgain = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{userName}, I'm going to try again. Please enter Y or N this time.");
                        continue;
                    }
                }
               
                if (goAgain) // Here's the bit where it goes all the way back to the top if they do want to go again.
                {
                    continue;
                }
                else
                {
                    break;
                }

            }


        }
    }
}
