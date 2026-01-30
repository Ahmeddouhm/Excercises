Console.WriteLine("=============================");
Console.WriteLine("Welcome To Birthday Getter :)");
Console.WriteLine("=============================");

DateTime userDate;
bool isValid = false;

while (!isValid)
{
    Console.Write("Enter Date : ");
    try
    {
        string[] formats = { "dd/M/yyyy", "dd/MM/yyyy", "MM/dd/yyyy" };
        userDate = DateTime.ParseExact(Console.ReadLine(), formats, null);
        if (userDate > DateTime.Now || userDate.Date == DateTime.Today || userDate.Year <= 1900)
        {
            Console.WriteLine("Enter Valid Date !");
            Console.WriteLine($"======================================");
            continue;
        }
        isValid = true;
        Console.WriteLine($"======================================");
        Console.WriteLine($"You Was Born in {userDate:dddd} / {userDate:MMMM} / {userDate.Year} ");
        Console.WriteLine($"======================================");
        TimeSpan difDate = DateTime.Now.Subtract(userDate);

        var years = difDate.TotalDays / 365.25;
        var remainderYears = (difDate.TotalDays % 365.25);

        var months = remainderYears / 30.4375;
        var days = (difDate.TotalDays % 365.25) % 30.4375;

        Console.WriteLine($"Your Age Now is ( {years:F2} Years / {(int)months} Months / {(int)days} Days ) and still counting ...");

    }
    catch (FormatException e)
    {
        Console.WriteLine($"[ERROR] : {e.Message}");
    }
}


// 3/28/2006

// You Was Born in ( DayName / MonthName / Year )
// Your Age Now is ( # Years / # Months / # Days ) and still counting ...
// Your Next BD in ( # Months , # Days )