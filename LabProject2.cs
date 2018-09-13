using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String DateOne, DateTwo;
            DateTime startdate, enddate; 

            Console.WriteLine(" Please provide first date in this form 'MM/DD/YYY' ");
               DateOne =  Console.ReadLine();


            Console.WriteLine(" Please provide second date in this form 'MM/DD/YYY' ");
            DateTwo = Console.ReadLine();

             startdate = DateTime.Parse(DateOne);
             enddate = DateTime.Parse(DateTwo);

            TimeSpan Difference = startdate.Subtract(enddate);

            Console.WriteLine(" The difference is a total of " + Difference.TotalDays.ToString() +" Days" + Difference.TotalHours.ToString()+ " " + "Hours" + " " + "and" + Difference.TotalMinutes + " " + "Minutes");
            Console.ReadLine();
         

        }
    }
}
