using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateText = Console.ReadLine();
            string format = "d-M-yyyy";
            DateTime date = DateTime.ParseExact(dateText, format, CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
      

        }
    }
}
