using Fundacion.Jala.DevInt.Shared.Models.Enums;
using System;
using System.Diagnostics;
using System.Text;

namespace Fundacion.Jala.DevInt.NetCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExplicitTypes();
            //ImplicitTypes();
            SampleInmmutability();
            //SampleIterators();
        }

        static void ExplicitTypes()
        {
            int positionX;
            float totalAmount;
            decimal price;
            double damage;
            string greetingVulcan;
            string greetingTranslate;
            bool isPricePositive;
            DateTime independenceDay;
            positionX = new Random().Next(100);
            totalAmount = 12.5f;
            price = CalculatePrice(10, 2.5m);
            isPricePositive = price > 0;
            damage = 200;
            greetingVulcan = "Dif-tor heh smusma";
            greetingTranslate = "Live Long and Prosper";
            independenceDay = new DateTime(1825, 8, 6);
            Console.WriteLine(string.Format("positionX: {0}", positionX));
            Console.WriteLine("totalAmount: {0}", totalAmount);
            Console.WriteLine("Price Positive?: {0}, price: {1}, ", isPricePositive, price);
            Console.WriteLine($"Damage done: {damage}");
            Console.WriteLine($"Greeting:{greetingVulcan}, Translation to ENG:{greetingTranslate}");
            Console.WriteLine($"Our Independence Day: {independenceDay.ToString("dd/MM/yyyy")}");
        }

        static void ImplicitTypes()
        {
            // var positionX; 
            var random = new Random();
            int positionX = random.Next(100);
            var totalAmount = 12.5f;
            decimal price = CalculatePrice(10, 2.5m);
            var isPricePositive = price > 0;
            var damage = 200;
            var greetingVulcan = "Dif-tor heh smusma";
            var greetingTranslate = "Live Long and Prosper";
            var bin1 = 1;
            var bin2 = 2;
            var resultXor = bin1 | bin2;
            var independenceDay = new DateTime(1825, 8, 6);
            Console.WriteLine("Xor Result:" + resultXor);
            Console.WriteLine(string.Format("positionX: {0}", positionX));
            Console.WriteLine("totalAmount: {0}", totalAmount);
            Console.WriteLine("Price Positive?: {0}, price: {1}, ", isPricePositive, price);
            Console.WriteLine($"Damage done: {damage}");
            Console.WriteLine($"Greeting:{greetingVulcan}, Translation to ENG:{greetingTranslate}");
            Console.WriteLine($"Our Independence Day: {independenceDay.ToString("dd/MM/yyyy")}");
        }

        static decimal CalculatePrice(int itemsQuantity, decimal price)
        {
            return itemsQuantity * price;
        }

        static void SampleInmmutability()
        {
            StringConcatenation();
            StringBuilderConcatenation();
        }

        static void StringConcatenation()
        {
            var allWednesdays = string.Empty;
            var timer = new Stopwatch();
            timer.Start();
            var startDate = new DateTime(1019, 1, 1);
            var endDate = DateTime.Now;
            
            do
            {
                var dayOfWeek = startDate.DayOfWeek;
                if (dayOfWeek == DayOfWeek.Wednesday)
                {
                    allWednesdays += startDate.Date.ToString("[yyyy-MM-dd]");
                }
                startDate = startDate.AddDays(1);
            } while (startDate <= endDate);
            timer.Stop();
            Console.WriteLine($"Time Elapsed SS:{timer.Elapsed.TotalSeconds}");
        }

        static void StringBuilderConcatenation()
        {
            var allWednesdays = new StringBuilder();
            var timer = new Stopwatch();
            timer.Start();
            var startDate = new DateTime(1019, 1, 1);
            var endDate = DateTime.Now;

            do
            {
                var dayOfWeek = startDate.DayOfWeek;
                if (dayOfWeek == DayOfWeek.Wednesday)
                {
                    allWednesdays.Append(startDate.Date.ToString("[yyyy-MM-dd]"));
                }
                startDate = startDate.AddDays(1);
            } while (startDate <= endDate);
            timer.Stop();
            Console.WriteLine($"Time Elapsed SB:{timer.Elapsed.TotalSeconds}");
        }

        static void SampleIterators()
        {
            var workingDays = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday"
            };
            
            var workingDaysCopy = workingDays.Clone() as string[];
            for (int i = 0; i < workingDaysCopy.Length; i++)
            {
                workingDaysCopy[i] = $"{workingDaysCopy[i]}-{i}";
                Console.WriteLine(workingDaysCopy[i]);
            }
           

            #region Negative Tests
            foreach (var day in workingDays)
            {
                if (!Enum.TryParse(typeof(WorkingDay), day, out var workingDay))
                {
                    continue;
                }
                var exclamation = string.Empty; // don't use ""
                Console.WriteLine(day);
                switch (workingDay)
                {
                    case WorkingDay.Monday:
                        exclamation = "Another Day, another lesson!";
                        break;
                    case WorkingDay.Tuesday:
                        exclamation = "At least it is not Monday";
                        break;
                    case WorkingDay.Wednesday:
                        exclamation = "A fine day";
                        break;
                    case WorkingDay.Thursday:
                        exclamation = "Almost Friday!";
                        break;
                    case WorkingDay.Friday:
                        exclamation = "TGIF!!";
                        break;
                    default:
                        break;
                }
                Console.WriteLine(exclamation);
            }
            #endregion
        }
    }
}
