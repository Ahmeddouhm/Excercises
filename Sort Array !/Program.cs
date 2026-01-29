Console.WriteLine("=======================");
Console.WriteLine("Welcome To Sort Array !");
Console.WriteLine("=======================");

Console.Write("Enter Array Size : ");
int arrSize = int.Parse(Console.ReadLine());
Console.Write("Enter Range Of Values : ");
int arrRangeOfVals = int.Parse(Console.ReadLine());

CreateArray(arrSize , arrRangeOfVals);


static void CreateArray(int size , int range) 
{
    Random rnd = new Random();
    int[] array = new int[size];
    int[] userArray = new int[size];


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
}
