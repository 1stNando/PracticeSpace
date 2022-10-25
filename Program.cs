using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
namespace PlainPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("Your a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are short");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but your are tall");
            }
            else
            {
                Console.WriteLine("You are not male and not tall");
            }
            // Here we are finally calling the GetMax method we first had to put together bellow the Main.
            // Dont forget to give the method the two values needed to start the comparison. Returns bigger#.
            Console.WriteLine(GetMax(20, 10, 40));
            Console.ReadLine();

            //New assignment: build a simple calculator.
            // - First we need a prompt to ask user for a number
            Console.Write("Enter a number: ");
            Console.ReadLine();

        }

        //Comparison statements within if 
        //We want this method to figure out which of the two numbers is bigger. And then return it to the caller
        // static int GetMax(int num1, int num2)
        // {
        //     int result;
        //     //lets use an if statement to apply this logic. A true or false condition goes inside the ().
        //     if (num1 > num2)//this compares the two. And resolves down to a true/false. Only two scenarios.
        //     {
        //         result = num1;
        //     }
        //     else
        //     {
        //         result = num2;
        //     }

        //     return result;
        // }//With this method done. We can now CALL IT in the Main!

        //this next version of GetMax will include a 3rd #.
        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            //Now we need a condition to check the 3.
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }



            return result;
        }//With this method done. We can now CALL IT in the Main!









    }
}

