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
            
            do
            {
                Console.WriteLine("Enter the semester(First,Second,Third,fourth) for which you want to calculate the fee.");
sem = Console.ReadLine();
                switch (sem.ToLower())
                {
                    case "first":
                       
                        Console.WriteLine($"Your {sem} semester fee is {fee-dis}");
                        break;
                    case "second":
                        myDec = 200;
                       
                        Console.WriteLine($"Your {sem} semester fee is {fee - dis - 1000 - (int)myDec}");
                        break;
                    case "third":
        
                        Console.WriteLine($"Your {sem} semester fee is {fee - dis - 2000}");
                        break;
                    case "fourth":
                        fee = fee - dis - 3000;
                        Console.WriteLine($"Your {sem} semester fee is {fee}");
                        break;
                    default:
                        Console.WriteLine("Please enter the valid semester!");
                        break;
                }
                Console.WriteLine("Do you want to continue?(y/n)");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y');
            Console.WriteLine($"Thank you {name}!!");
        }
    }
}
