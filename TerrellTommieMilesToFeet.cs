/*
 * Tommie Terrell
 * Program converts miles to feet
 * 2-2-2016
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrellTommieMilesToFeet
{
    class MilesToFeet
    {
        static void Main(string[] args)
        {
            const double FeetinMile = 5280;
            double Miles = 8.5;
            double totDistance;
            totDistance = Miles * FeetinMile;
   
            Console.WriteLine(" My uncle's house is "+ Miles +" miles or "+totDistance+" feet");

        }
    }
}
