Console.WriteLine("=======================");
Console.WriteLine("Welcome To Sort Array !");
Console.WriteLine("=======================");

Console.Write("Enter Array Size : ");
int arrSize = int.Parse(Console.ReadLine());
Console.Write("Enter Range Of Values : ");
int arrRangeOfVals = int.Parse(Console.ReadLine());

Console.WriteLine((Validation(CreateArray(arrSize, arrRangeOfVals), TakeUserArray(arrSize))) ? "TRUE" : "FALSE");

static int[] CreateArray(int size , int range) 
{
    Random rnd = new Random();
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        int numToCheck;
        do
        {
            numToCheck = rnd.Next(1, range);
        } while (array.Contains(numToCheck));

        array[i] = numToCheck;
        Console.Write($"[{array[i]}]");
    }

    return array;
}

static int[] TakeUserArray(int size) 
{
    int[] userArray = new int[size];

    for (int i = 0; i < userArray.Length; i++)
    {
        Console.Write($"\nEnter [{i}] : ");
        userArray[i] = int.Parse(Console.ReadLine());
    }

    foreach (var item in userArray)
    {
        Console.Write($"{item} ");
    }

    return userArray;
}

static bool Validation(int[] array,int[] userArray) 
{
    array.Sort();
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == userArray[i])
        {
            count++;
        }
        else
        {
            return false;
        }
    }
    return true;
}
