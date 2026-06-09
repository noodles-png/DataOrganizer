using DataOrganizer;


string directoryPath = "Insert/Path/here"; // Insert Path in between "..."

var program = new FileOrganizer(directoryPath);

if (!Directory.Exists(directoryPath))
{
    Console.WriteLine("Directory doesn't exist");
    Console.ReadKey();
    return;
}

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
            break;
        }
    }
}

Console.WriteLine("Press any key to close...");
Console.ReadKey();