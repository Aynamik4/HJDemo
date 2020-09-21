using System;

namespace EnumDemo
{
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            HandleDayOfWeek(DayOfWeek.Monday);

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Tab:
                    break;
                case ConsoleKey.Clear:
                    break;
                default:
                    break;
            }
        }

        static void HandleDayOfWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                case DayOfWeek.Sunday:
                    break;
                default:
                    break;
            }
        }
    }
}
