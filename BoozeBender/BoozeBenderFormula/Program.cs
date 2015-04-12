using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozeBenderFormula
{
    class Program
    {

        static void Main (string [] args)
        {
            Console.WriteLine (string.Format ("\n/*****  'Booze bender' formula implementation  *****/\n\n"));
            
            // declare variables we'll need & set some initial values...

            var amountOfSpirit = -1d;   // 'd' here forces the variable to be a 'double', which can have a decimal point and fractional value....
            var alcoholByVolume = -1d;
            var desiredAbv = -1d;
            var amountOfWater = -1d;

            /*  Formula for amount of water to add: 
             *  ((amount of spirit)(ABV of spirit - ABV desired)) / (ABV desired)
             * 
             * ...note the nested parentheses; important here. 
             * 
             * The units don't matter here, since we'll assume whatever unit is 
             *  used for the input will be the same for the output.
             * 
             */


            // so...set some more meaningful values:

            amountOfSpirit = 10;    // 10 ounces/liters/whatever, really
            alcoholByVolume = 63;   // straight off the still strength...
            desiredAbv = 40;        // bottle strength


            // now apply the formula and trap the result in our 'amountOfWater' variable:
            
            amountOfWater = (amountOfSpirit * (alcoholByVolume - desiredAbv)) / desiredAbv;


            // show output to console:

            Console.WriteLine (string.Format (" {0, -24}{1,7:#.00}", "Volume of spirit:", amountOfSpirit));
            Console.WriteLine (string.Format (" {0, -24}{1,7:#.00}", "ABV of spirit:", alcoholByVolume));
            Console.WriteLine (string.Format (" {0, -24}{1,7:#.00}", "Desired ABV:", desiredAbv));
            Console.WriteLine (string.Format (" {0, -24}{1,7:#.00}", "Amount/water to add:", amountOfWater));
            // bonus points; how much will we wind up with total?
            Console.WriteLine (string.Format (" {0, -24}{1,7:#.00}", "Final volume/proofed:", amountOfWater + amountOfSpirit));    

            Console.WriteLine (string.Format ("\n Press <Enter> to end..."));

            Console.ReadLine ();        // waits for the user to hit the enter key before the program ends...
        }
 
    }
}
