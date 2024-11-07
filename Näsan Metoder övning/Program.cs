using System.Reflection.Metadata;


GetChoice("Knife", "scythe", "A child");


static int GetChoice(string choice1, string choice2, string choice3)
{
    
    string userChoice = "";
    int userNumber;
    Console.WriteLine($"1.{choice1}");
    Console.WriteLine($"2.{choice2}");
    Console.WriteLine($"3.{choice3}");


    userChoice = Console.ReadLine();
    int.TryParse(userChoice, out userNumber);

    while (!userNumber.Equals(1) && !userNumber.Equals(2) && !userNumber.Equals(3))
    {
        Console.WriteLine("Please enter a valid input");
        userChoice = Console.ReadLine();
        int.TryParse(userChoice, out userNumber);
    }

    Console.WriteLine($"You picked somehtng ({userNumber})");
    Console.ReadLine();

    return userNumber;
}