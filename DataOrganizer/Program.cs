using DataOrganizer;

string directoryPath = "Insert Directory here"; // Insert Path inbetween "..."

var program = new FileOrganizer($@"{directoryPath}");

while (true)
{
    program.Preview();
    
    Console.WriteLine("Continue? [Y|N]");
    string userInput1 = Console.ReadLine().ToLower();
    
    if (userInput1 == "y")
    {
        program.Organize();
        break;
    }
    else    
    {
        Console.WriteLine("Try again? [Y|N]");
        string userInput2 = Console.ReadLine();
        userInput2 = userInput2.ToLower();
        if (userInput2 == "y")
        {
            continue;
        }
        else
        {
            return;
        }
    }
}


