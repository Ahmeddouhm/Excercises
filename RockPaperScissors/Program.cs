Console.WriteLine("==========================");
Console.WriteLine("   Hello To RPS Game :)");

Random rnd = new Random();
bool isFinished = false;
string choiceUser,choiceAI = string.Empty;
string[] valid = new string[] { "P", "S", "R" };

while (!isFinished)
{
    int code = rnd.Next(1 , 4);
    Console.WriteLine("==========================");
    Console.Write("Enter Choice (P - S - R) : ");
    choiceUser = Console.ReadLine().ToUpper();

    if (!(valid.Contains(choiceUser)))
    {
        Console.WriteLine("[Error] => Enter Valid Move!");
        continue;
    }

    switch (code)
    {
        case 1:
            choiceAI = "P";
            break;
        case 2:
            choiceAI = "S";
            break;
        case 3:
            choiceAI = "R";
            break;
    }

    Console.WriteLine("==========================");
    Console.WriteLine($"User : [{choiceUser}] vs AI : [{choiceAI}]");
    Console.WriteLine("==========================");

    switch (choiceUser)
    {
        case "P":
            if (choiceAI == "S") { Console.WriteLine("[You Lost !]"); }
            else if (choiceAI == "P") { Console.WriteLine("[It's Draw !]"); }
            else if (choiceAI == "R") { Console.WriteLine("[You Won !]"); }
            break;
        case "S":
            if (choiceAI == "R") { Console.WriteLine("[You Lost !]"); }
            else if (choiceAI == "S") { Console.WriteLine("[It's Draw !]"); }
            else if (choiceAI == "P") { Console.WriteLine("[You Won !]"); }
            break;
        case "R":
            if (choiceAI == "P") { Console.WriteLine("[You Lost !]"); }
            else if (choiceAI == "R") { Console.WriteLine("[It's Draw !]"); }
            else if (choiceAI == "S") { Console.WriteLine("[You Won !]"); }
            break;
    }
    Console.WriteLine();
    Console.Write("Wanna Play Again ? (Y / N) : ");
    string answer = Console.ReadLine().ToUpper();
    if (!(answer == "Y"))
    {
        isFinished = true;
    }

}
