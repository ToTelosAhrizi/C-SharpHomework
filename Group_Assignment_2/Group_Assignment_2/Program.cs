using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {            
            int oor = 0;
            int valid = 0;
            int nonvalid = 0;
            int counter = 0;            
            string input;
            WriteLine("Enter 11 inputs");
            string[] array = new string[11];
            while (counter < 11)
            {
                input = ReadLine();
                array[counter] = (input);
                counter++;
                if (int.TryParse(input, out int i) && i >= 0 && i <= 10)
                {                    
                    valid++;                    
                }
                else if (int.TryParse(input, out i) && i < 0 ||  i > 10)
                {                    
                    oor++;
                }
                else
                {                                       
                    nonvalid++;
                }                
            }
            WriteLine("Valid: " + valid + "\nOut of Range: " + oor + "\nNonValid: " + nonvalid);
            string[] ten = Array.FindAll(array, element => element.Equals("10"));
            int tenn = ten.Count();
            string[] nine = Array.FindAll(array, element => element.Equals("9"));
            int ninn = nine.Count();
            string[] eight = Array.FindAll(array, element => element.Equals("8"));
            int ate = eight.Count();
            string[] seven = Array.FindAll(array, element => element.Equals("7"));
            int sev = seven.Count();
            string[] six = Array.FindAll(array, element => element.Equals("6"));
            int sixx = six.Count();
            string[] five = Array.FindAll(array, element => element.Equals("5"));
            int fiv = five.Count();
            string[] four = Array.FindAll(array, element => element.Equals("4"));
            int fur = four.Count();
            string[] three = Array.FindAll(array, element => element.Equals("3"));
            int tree = three.Count();
            string[] two = Array.FindAll(array, element => element.Equals("2"));
            int twoo = two.Count();
            string[] one = Array.FindAll(array, element => element.Equals("1"));
            int on = one.Count();
            string[] zero = Array.FindAll(array, element => element.Equals("0"));
            int zro = zero.Count();
            int[,] count_off = new int[11, 2];
            count_off[0, 0] = 0;
            count_off[1, 0] = 1;
            count_off[2, 0] = 2;
            count_off[3, 0] = 3;
            count_off[4, 0] = 4;
            count_off[5, 0] = 5;
            count_off[6, 0] = 6;
            count_off[7, 0] = 7;
            count_off[8, 0] = 8;
            count_off[9, 0] = 9;
            count_off[10, 0] = 10;

            count_off[0, 1] = zro;
            count_off[1, 1] = on;
            count_off[2, 1] = twoo;
            count_off[3, 1] = tree;
            count_off[4, 1] = fur;
            count_off[5, 1] = fiv;
            count_off[6, 1] = sixx;
            count_off[7, 1] = sev;
            count_off[8, 1] = ate;
            count_off[9, 1] = ninn;
            count_off[10, 1] = tenn;
            WriteLine("This will show how much of each valid number was input.");
            WriteLine("Number         Amount input");
            WriteLine(count_off[0, 0] + "\t       " + count_off[0, 1]);
            WriteLine(count_off[1, 0] + "\t       " + count_off[1, 1]);
            WriteLine(count_off[2, 0] + "\t       " + count_off[2, 1]);
            WriteLine(count_off[3, 0] + "\t       " + count_off[3, 1]);
            WriteLine(count_off[4, 0] + "\t       " + count_off[4, 1]);
            WriteLine(count_off[5, 0] + "\t       " + count_off[5, 1]);
            WriteLine(count_off[6, 0] + "\t       " + count_off[6, 1]);
            WriteLine(count_off[7, 0] + "\t       " + count_off[7, 1]);
            WriteLine(count_off[8, 0] + "\t       " + count_off[8, 1]);
            WriteLine(count_off[8, 0] + "\t       " + count_off[9, 1]);
            WriteLine(count_off[10, 0] + "\t       " + count_off[10, 1]);
            ReadKey();
        }
    }
}
