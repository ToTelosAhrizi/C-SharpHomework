using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Programming exersise two*/
            WriteLine("Program 1 assignment 2\n");
            double miles = 5;
            double feet = miles * 5280;
            double km = miles * 1.6;
            WriteLine("Number of miles:");
            WriteLine("{0:####.##}", miles);
            WriteLine("Number of feet in set miles:");
            WriteLine("{0:#####.##}", feet);
            WriteLine("Number of kilometers in set miles:");
            WriteLine("{0:####.##}", km);
            ReadKey();
            /*Programming exersise 3*/
            WriteLine("\nProgram 2 assignment 2\n");
            double bill = 20;
            double fiftip = bill * 0.15;
            double twentip = bill * 0.2;
            double fifbill = bill + fiftip;
            double twenbill = bill + twentip;
            WriteLine("Your bill is:");
            WriteLine("{0:c}",bill);
            WriteLine("A fifteen percent tip is:");
            WriteLine("{0:c}", fiftip);
            WriteLine("A twenty percent tip is:");
            WriteLine("{0:c}", twentip);
            WriteLine("Bill with 15% tip");
            WriteLine("{0:c}", fifbill);
            WriteLine("Bill with 20% tip"); 
            WriteLine("{0:c}", twenbill);
            ReadKey();
            /*Programming exersise ten
             1 pound = 453.59237 grams*/
            WriteLine("\nProgram 3 assignment 2\n");
            double gramspout = 100;
            double gramshv = 100;
            double poundspout = gramspout / 453.59237;
            double poundshv = gramshv / 453.59237;
            WriteLine("100 grams of poutine in pounds " + poundspout);
            WriteLine("100 grams of haricot in pounds " + poundshv);

           
            ReadKey();
        }
    }
}
