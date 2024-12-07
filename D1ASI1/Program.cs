internal class Program
{
    private static void Main(string[] args)
    {
        // Assignment: Calcualte the AGE difference between today and a certain birthdate.
        // Still need to change the today date to be input..
        #region Calculate Age
        int year;
        int month;
        int day;

        do
        {
            Console.WriteLine("Enter The Year: ");

            year = int.Parse(Console.ReadLine());
        }
        while (year < 0);

        do
        {
            Console.WriteLine("Enter The Month: ");
            month = int.Parse(Console.ReadLine());
        }
        while (0 > month || month > 13);
        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            do
            {
                Console.WriteLine("Enter The Day: ");

                day = int.Parse(Console.ReadLine());
            }
            while (day > 31 || day < 0);
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            do
            {
                Console.WriteLine("Enter The Day: ");

                day = int.Parse(Console.ReadLine());
            }
            while (day > 30 || day < 0);
        }
        else
        {
            do
            {
                Console.WriteLine("Enter The Day: ");

                day = int.Parse(Console.ReadLine());
            }
            while (day > 29 || day < 0);
        }
        Console.WriteLine($"You're born {day},  {month} in {year}");

        int todayDay = 28;
        int todayMonth = 06;
        int todayYear = 2024;

        int yearDiff;
        int monthDiff;
        int dayDiff;

        yearDiff = todayYear - year;
        monthDiff = todayMonth - month;
        dayDiff = todayDay - day;

        if (dayDiff < 0)
        {
            monthDiff -= 1;
            dayDiff += 30;
        }
        if (monthDiff < 0)
        {
            yearDiff -= 1;
            monthDiff += 12;
        }
        Console.WriteLine($"the difference is: {yearDiff} Year, {monthDiff} Months, {dayDiff} Days");
    }








    #endregion
}
