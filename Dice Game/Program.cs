Console.WriteLine("==========================");
Console.WriteLine("Hello To Dice Game :)");
Console.WriteLine("To Exit Enter \"ex\"");

Console.Write("Enter Your Name : ");
string username = Console.ReadLine();

bool isFinished = false;
int rounds;

Random rnd = new Random();

while (!isFinished)
{
    int scoreUser = 0;
    int scoreAI = 0;
    Console.WriteLine("==========================");
    Console.Write("Enter Rounds : ");
    string? input = Console.ReadLine();
    if (input == "ex")
    {
        break;
    }
    else 
    {
        rounds = int.Parse(input);
    }

    if (!(rounds % 2 == 1) && rounds > 0)
    {
        Console.WriteLine("Enter a Valid Odd Number >)");
        continue;
    }

    for (int i = 0; i < rounds; i++)
    {
        int diceUser = rnd.Next(1, 7);
        int diceAI = rnd.Next(1, 7);

        Console.WriteLine("Press Any Key To Roll");
        Console.ReadKey();
        Console.WriteLine($"-- Round {i+1} --");
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".\n");
        Thread.Sleep(500);

        if (diceUser > diceAI)
        {
            scoreUser++;
            Console.WriteLine($"{username} Won => {scoreUser} : {scoreAI}");
            Console.WriteLine($"{username} Won => {diceUser} : {diceAI}");
        }
        else if (diceUser < diceAI)
        {
            scoreAI++;
            Console.WriteLine($"AI Won => {scoreUser} : {scoreAI}");
            Console.WriteLine($"AI Won => {diceUser} : {diceAI}");
        }
        else 
        {
            Console.WriteLine("DRAW");
            i--;
            continue;
        }

        int roundsToWin = (int)Math.Ceiling((double)rounds / 2);
        int remainRounds = rounds - (i + 1);

        if (scoreUser == roundsToWin)
        {
            Console.WriteLine($"{username} Won't Lose Today hahaha");
        }
        else if (scoreAI == roundsToWin) 
        {
            Console.WriteLine("AI Won't Lose Today hahaha");
        }


        if (scoreAI + remainRounds < roundsToWin)
        {
            Console.WriteLine($"Congratulations in advance {username}");
        } else if (scoreUser + remainRounds < roundsToWin) 
        {
            Console.WriteLine("Congratulations in advance AI");
        }
        
    }
}