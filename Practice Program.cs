using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
       
        static void Main(string[] args)
        {
            char firstInitial = 'R';
            double date = 8.21;
           
            Console.WriteLine("enter your name");
            string yourName= Console.ReadLine();
            Console.WriteLine("enter your birthyear");
            int birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the current year");
            int currYear = int.Parse(Console.ReadLine());




            Console.WriteLine("Hello {0}",yourName);
            Console.WriteLine("Current Year:{0}", currYear);
            Console.WriteLine("Your Birthday:{0}", birthYear);
            int age = currYear - birthYear;
            Console.WriteLine();
            Console.WriteLine("You are approximately {0} years old", age);

            Console.WriteLine("Please choose two numbers.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("And");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Your chosen numbers are {0} and {1}.", num1, num2);

                int add = num1 + num2;
                int sub = num1 - num2;
                int div = num1 / num2;
                int rem = num1 % num2;
                int mult = num1 * num2;
            Console.WriteLine("{0} + {1} = {2}, {0} - {1} = {3}, {0} / {1} = {4} with {5} remaining, {0} * {1} = {6}", num1, num2, add, sub, div, rem, mult);

            // It was at this point I knew... I was going a little to in depth with this

            num1--;
            num2++;
            string answer = "no";
            do
            { 
           
                Console.WriteLine("Are you in a coding class?");
            
            
                answer = Console.ReadLine();

             } while (answer != "yes");

            string secinput = "no";
            while (secinput != "yes")
            {
                Console.WriteLine("Are you sure?");
                secinput = Console.ReadLine();

                if (secinput == "no")
                    Console.WriteLine("Try again");

                else if (secinput == "yes")
                    Console.WriteLine("Good");

                else
                    Console.WriteLine("That isn't what I'm looking for");
            }

            string down = "Countdown in";
            for (int count= 10; count != 0; count --)
            {
                
                Console.WriteLine("{0} {1}", down, count);
                down = "";
            }
            var numbersUsed = new List<int>{ birthYear, currYear, age, add, sub, div, rem, mult, };
            Console.WriteLine("Printing all numbers used in this istance of the program.");
            foreach (var item in numbersUsed)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Thank you and goodbye.");

        }
    }
}
