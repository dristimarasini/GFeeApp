using System;

namespace GFeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************Graduate Semester Fee Calculator App******************");
            var fee = 7000;
            var myGPA = 0.00;
            var ch = 'n';
            var name = "";
            bool decision = false;
            decimal myDec = 0.0m;
            var GPA = "";
            var sem="";
            var dis = 0;
            
            do
            {
                Console.WriteLine("Enter your Name");
                name = Console.ReadLine();
                decision = (name == String.Empty);
            }
           while (decision);
            Console.WriteLine($"********Welcome {name}*************");
            do
            {
                Console.WriteLine("Enter your GPA");
                GPA = Console.ReadLine();
            }
            while (GPA == String.Empty);
            myGPA = Convert.ToDouble(GPA);

          
            if (myGPA > 3.3)
            {
                dis = 3000;
            }
        }
    }
}
