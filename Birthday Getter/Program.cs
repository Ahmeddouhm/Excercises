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

        DateTime today = DateTime.Today;
        DateTime nextBirthday = new DateTime(today.Year, userDate.Month, userDate.Day);

        if (nextBirthday < today)
        {
            nextBirthday.AddYears(1);
        }

        TimeSpan remainDays = (nextBirthday - today);

        int years = today.Year - userDate.Year;
        if (today < userDate.AddYears(years))
            years--;

        userDate = userDate.AddYears(years);

        int months = 0;
        while (userDate.AddMonths(1) <= today)
        {
            userDate = userDate.AddMonths(1);
            months++;
        }

        int days = (today - userDate).Days;


        Console.WriteLine($"Your Age Now is ( {years:F0} Years / {(int)months} Months / {(int)days} Days ) and still counting ...");
        
        Console.WriteLine($"Your Next BirthDay in {remainDays.Days} Days");


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