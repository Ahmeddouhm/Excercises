Console.WriteLine("======================");
Console.WriteLine("Welcome To Combat Game");
Console.WriteLine("======================");


Console.Write("Enter username : ");
string username = Console.ReadLine();
Console.WriteLine($"Welcome {username} !");


Random rnd = new Random();
int playerHP = 100 , enemyHP = 100;
int playerAtt = 5, enemyAtt = 7;
int heal = 5;

while (playerHP > 0 && enemyHP > 0)
{
    Console.Write("Player Turn (A => Attack | H => Heal) : ");
    string choice = Console.ReadLine().ToUpper();

    if (choice == "A")
    {
        enemyHP -= playerAtt;
        Console.WriteLine($"------{username}------");
        Console.WriteLine($"{username} Attacks and deals {playerAtt}");
        Console.WriteLine("-----------------------");
    }
    else if (playerHP < 100 && choice == "H")
    {
        playerHP += heal;
        Console.WriteLine($"------{username}------");
        Console.WriteLine($"{username} restored heal by {heal}");
        Console.WriteLine("-----------------------");
    }
    Console.WriteLine("=======HP=======");
    Console.WriteLine($"{username} : {playerHP} VS Enemy : {enemyHP}");
    Console.WriteLine("==============");
    if (choice == "A" || choice == "H")
    {
        int move = rnd.Next(0, 2);

        if (move == 0)
        {
            playerHP -= enemyAtt;
            Console.WriteLine($"------Enemy------");
            Console.WriteLine($"Enemy attacks and deals {enemyAtt}!");
            Console.WriteLine("-----------------------");
        }
        else if (enemyHP < 100)
        {
            enemyHP += heal;
            Console.WriteLine($"------Enemy------");
            Console.WriteLine($"Enemy restored {heal} health!");
            Console.WriteLine("-----------------------");
        }
    }
    Console.WriteLine("=======HP=======");
    Console.WriteLine($"{username} : {playerHP} VS Enemy : {enemyHP}");
    Console.WriteLine("==============");
}

if (playerHP > 0)
    Console.WriteLine($"{username} wins!");
else
    Console.WriteLine("You were defeated!");