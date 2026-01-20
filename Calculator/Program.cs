using System.Text;

Console.WriteLine("==========================");
Console.WriteLine("Hello To My Simple Calc :)");
Console.WriteLine("To Exit Enter \"ex\"");
Console.WriteLine("==========================");

bool isFinished = false;

while (!isFinished)
{
    Console.Write($"Enter Expression : ");
    string? input = Console.ReadLine();
    if (input == "ex") 
    {
        isFinished = true;
        break;
    }

    string[] expr = input.Split();
    if (expr.Length != 3)
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Enter a Valid Expression like: 5 + 3");
        Console.WriteLine("--------------------------");
        continue;
    }

    if (char.TryParse(expr[1], out char @operator) && (@operator == '-' || @operator == '*' || @operator == '+' || @operator == '/'))
    {
    }
    else
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Enter Valid Operator");
        Console.WriteLine("--------------------------");
        continue;
    }

    if (!decimal.TryParse(expr[0], out decimal leftOperand) || !decimal.TryParse(expr[2], out decimal rightOperand))
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Enter valid numbers");
        Console.WriteLine("--------------------------");
        continue;
    }

    Console.WriteLine("==========================");

    switch (@operator)
    {
        case '+':
            Console.WriteLine($"Result : {Add(leftOperand, rightOperand)}");
    Console.WriteLine("==========================");
            break;
        case '-':
            Console.WriteLine($"Result : {Sub(leftOperand, rightOperand)}");
    Console.WriteLine("==========================");

            break;
        case '*':
            Console.WriteLine($"Result : {Mup(leftOperand, rightOperand)}");
    Console.WriteLine("==========================");

            break;
        case '/':
            try { Console.WriteLine($"Result : {Div(leftOperand, rightOperand)}"); }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Don't NEVER EVER Divide By ZERO DUMPASS >)");
                Console.WriteLine("--------------------------");
            }
    Console.WriteLine("==========================");
            break;
    }
}

static decimal Add(decimal a , decimal b) 
{
    return a + b;
}
static decimal Sub(decimal a , decimal b) 
{
    return a - b;
}
static decimal Div(decimal a , decimal b) 
{
    return a / b;
}
static decimal Mup(decimal a , decimal b) 
{
    return a * b;
}
