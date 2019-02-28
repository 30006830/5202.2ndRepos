using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMyLife_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;

            string fname;
            string lname;
            string address;
            int age;
            string emailaddress;
            int pin;
            int num1;
            decimal dec1;
            double dec2;
            float dec3;


            Console.WriteLine("Please enter your full name: ");
            fname = Console.ReadLine();
            Console.WriteLine("If you have entered your full name just press enter again till the next prompt appears. \nIf not and you typed out your first name, you'll need to type your last name now then press enter. ");
            lname = Console.ReadLine();
            Console.WriteLine("Thanks.");

            Console.WriteLine("Now enter your Address (Street, Town, Suburb, etc.): ");
            address = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Now enter your email address: ");
            emailaddress = Console.ReadLine();

            Console.WriteLine("Finally enter a PIN number: ");
            pin = int.Parse(Console.ReadLine());

            Console.WriteLine("Just kidding, theres more. Please enter an Integer: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Decimal: ");
            dec1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Now for a second Decimal, maybe like a... a Double: ");
            dec2 = double.Parse(Console.ReadLine());

            Console.WriteLine("I promise this is the last, enter a third Decimal. Particularly a Float: ");
            dec3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Processing...");
            Console.ReadLine();

            Console.WriteLine("Results: ");
            Console.WriteLine("Full Name: " + fname + " " + lname);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Email Address: " + emailaddress);
            Console.WriteLine("PIN: " + pin);
            Console.WriteLine("Int: " + num1);
            Console.WriteLine("Dec 1 (Decimal): " + dec1);
            Console.WriteLine("Dec 2 (Double): " + dec2);
            Console.WriteLine("Dec 3 (Float): " + dec3);


            Console.ReadLine();





        }
    }
}
