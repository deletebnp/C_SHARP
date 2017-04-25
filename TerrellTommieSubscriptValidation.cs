///Tommie Terrell
///4/26/16
///Subscript Validation


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptValidation
{
    class SubVal
    {
        static void Main(string[] args)
        {   
            int number;
            int[] numbers =  { 5, 2, 7, 20, 5, 6, 88, 8, 26, 45 };//Creates array to 10 different numbers
            Console.WriteLine("Please enter a number from 1 to 10");/// Ask user to enter option

            try
            {
                int ans;
                number = Convert.ToInt32(Console.ReadLine());/// passes information to variable number
                ans = (number - 1);// Subtract 1 from variable to select correct array subscript
                if
                    (ans >= 0 || ans <= 10)// If user enters number outside of 1 and 10 it will catch
                


                    Console.WriteLine("Your number is  "+ numbers[ans]);// displays answer
            }
            catch (IndexOutOfRangeException)///   catch when data is outside of limits
            {
                Console.WriteLine("Your number is out of range. Please enter a number between 1 to 10");
            }
        }
    }
}