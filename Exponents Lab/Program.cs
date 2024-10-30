bool agreePlayAgain = false;

do
{
    Console.WriteLine("Please enter a whole number");
    string userInput = Console.ReadLine();
    int userNumber = 0;
    bool validNumber = int.TryParse(userInput, out userNumber);

    while (validNumber == false || userNumber <=0)
    {
        Console.WriteLine("Incorrect input. Please enter a whole number.");
        userInput = Console.ReadLine();
        validNumber = int.TryParse(userInput, out userNumber);
    }

    if (validNumber == true)
    {
        Console.WriteLine("\nNumber\tSquared\tCubed"); // n = moves to a new line, t = adds a tab space
        {
            for (int i = 1; i <= userNumber; i++)
            {
                int squared = i * i;
                int cubed = i * i * i;
                Console.WriteLine($"\n{i}\t{squared}\t{cubed}");
            }
            Console.WriteLine("Would you like to continue? (y/n)");
            string userResponse = Console.ReadLine();
            {
                if (userResponse.ToLower() == "y")
                {
                    agreePlayAgain = true;
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }
    }
} while (agreePlayAgain = true);

// Tell us what kind of loop you used and describe how your solution would have changed if you had used a different type of loop.

// I used a for loop to calculate the solution as we are able to set a for loop to run a specific number of times and we are able to manipulate the number
// entered by the user. I do not believe this calculation would have been possible with any other loop, as we are unsure what number the user will enter when prompted.
