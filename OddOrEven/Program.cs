/*
 * Jan 18, 2018
 * William H Smith UMSL INFSY-6805 C# and .NET
 * 
 * Write an app that reads an integer, then determine and displays whether
 * it is odd or even.Hint: use the remainder operator. An even number is a 
 * multiple of 2. Any multiple of 2 leaves a remainder of 0 when divided by 2.
 * I also added input validation, which was not nessisarily part of this assignment.
 * 
 */

using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args){
            //Title and intro
            Console.WriteLine("\n\n*** Odd or Even integer with testing if integer *** \n\n");
            Console.Write("Enter an integer to be tested if Odd or Even: ");

            //Read in the number and trim just in case
            string Str = Console.ReadLine().Trim();

            Console.WriteLine("");  //Just to add a space

            //Where the magic happens 
            int Num;
            bool isNum = int.TryParse(Str, out Num);
            if (isNum){
                //Console.WriteLine(Num.ToString() + " is a valid number!");
                int y = Num % 2;
                if (y == 0){
                    Console.WriteLine("The integer " + Num + " is an Even number!");
                }else{
                    Console.WriteLine("The integer " + Num + " is an Odd number!");
                }
            }else{
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
