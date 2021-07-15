using System;

namespace zellers_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;
            int weekday, zmonth, zyear;
            
            Console.WriteLine("Wanna Know Which Day You Were Born? \n\nENTER YOUR BIRTHDAY:");
            Console.Write("YEAR:");
            year = int.Parse(Console.ReadLine());
            Console.Write("MONTH:");
            month = int.Parse(Console.ReadLine());
            Console.Write("DAY:");
            day = int.Parse(Console.ReadLine());

            zmonth = month - 2;
            zyear = year;

            if (zmonth <= 0)
            {
                zmonth += 12;
                zyear--;
            }
           weekday = ((day + ((13 * zmonth - 1) / 5) + ((5 * (zyear % 100)) / 4) - ((7 * zyear) / 400)) % 7);

            if (weekday < 0)
            {
                weekday += 7;
            }

            switch (weekday)
            {
                case 0:
                    Console.WriteLine("You Were Born On A Sunday!");
                    break;
                case 1:
                    Console.WriteLine("You Were Born On A Monday!");
                    break;
                case 2:
                    Console.WriteLine("You Were Born On A Tuesday!");
                    break;
                case 3:
                    Console.WriteLine("You Were Born On A Wednesday!");
                    break;
                case 4:
                    Console.WriteLine("You Were Born On A Thursday!");
                    break;
                case 5:
                    Console.WriteLine("You Were Born On A Friday!");
                    break;
                case 6:
                    Console.WriteLine("You Were Born On A Saturday!");
                    break;
            }

        }
    }
}
