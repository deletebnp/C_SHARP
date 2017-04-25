/* Tommie Terrell
 * SDEV 240
 * ARRAYS
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main()
        {
            int[] validAreaCodes = { 262, 414, 608, 715, 815, 920 }; /// assigning area codes to area code array
            double[] pricePerMin = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };/// assigning prices for area codes
            int areaCodeSel;
            int minutes;
           decimal  totalPrice = 0;
            bool validMatch = false;
            Console.Write("Please enter Area code ");/// user area code input
            areaCodeSel = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter total minutes: ");/// user minutes
            minutes = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < validAreaCodes.Length; ++x)/// it uses a for loop to search the array for the valid area code
            {
                if (areaCodeSel == validAreaCodes[x])
                {
                    validMatch = true;
                    totalPrice = Convert.ToDecimal(minutes * pricePerMin[x]);///  this multiples per per min and user minutes to get answer
                }
            }
            
            if (validMatch)
                Console.WriteLine(" The Total Price is ${0}",( totalPrice)); /// displays answer
            else
                Console.WriteLine("Sorry invalid entry");
        }
    }
}
