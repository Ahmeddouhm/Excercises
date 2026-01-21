Console.WriteLine("==========================");
Console.WriteLine("Hello To Guess Number Game :)");
Console.WriteLine("==========================");

bool isFinished = false;
Random rnd = new Random();
int gamesPlayed = 0;
int totalGuesses = 0;

while (!isFinished)
{
    int secretNumber = rnd.Next(1, 11);
    int guess = 0;
    int guesses = 1;
    while (guess != secretNumber)
    {
        Console.Write("Enter Your Guess : ");
        try { guess = int.Parse(Console.ReadLine()); }
        catch (Exception e) { Console.WriteLine(e.Message); }
        if (guess >= 10 || guess <= 0)
        {
            Console.WriteLine("Enter in Range 1 - 10");
        }
        else if (guess < secretNumber )
        {
            Console.WriteLine("Be Higher");
            guesses++;
        }
        else if (guess > secretNumber )
        {
            Console.WriteLine("Be Lower");
            guesses++;
        }
    }

    Console.WriteLine($"Congrats ! After {guesses} Guesses");
    gamesPlayed++;
    totalGuesses += guesses;
    Console.WriteLine("==========================");

    Console.Write("Wanna Play Again ? (yes / no) : ");
    string? input = Console.ReadLine();
    if (input.ToLower() == "yes")
        isFinished = false;    
    else
        isFinished = true;
}

if (gamesPlayed > 1)
{
    Console.WriteLine("==========================");
    Console.WriteLine($"Total Games Played {gamesPlayed} Games");
    Console.WriteLine($"AVG Guesses per Game = {(double)totalGuesses / gamesPlayed:F2}");
    Console.WriteLine("==========================");
}