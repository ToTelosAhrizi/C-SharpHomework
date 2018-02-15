using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


/// <summary>
/// Exercise 1, 3 and 6 for assignment 5
/// </summary>
namespace Assignment_5_DJH
{
    class Program
    {
        static void Main(string[] args)
        {
            RoNumDis.Display();//Exercise 1
            BMI.InputBMI();    //Exercise 3
            Area.AreaDisplay();//Exercise 6

        }
    }
    //Main End
    //Exercise 1 class and method beginning.
    class RoNumDis
    {
        public static void Display()
        {
            RoNumInput one = new RoNumInput();
            one.Input();
        }
    }
    class RoNumInput
    {
        public void Input()
        {
            string number;
            int num;
            WriteLine("Enter your number:");
            number = ReadLine();
            if (int.TryParse(number, out num))
            {
                switch (num)
                {
                    case 1:
                        WriteLine("I");
                        ReadKey();
                        break;
                    case 2:
                        WriteLine("II");
                        ReadKey();
                        break;
                    case 3:
                        WriteLine("III");
                        ReadKey();
                        break;
                    case 4:
                        WriteLine("IV");
                        ReadKey();
                        break;
                    case 5:
                        WriteLine("V");
                        ReadKey();
                        break;
                    case 6:
                        WriteLine("VI");
                        ReadKey();
                        break;
                    case 7:
                        WriteLine("VII");
                        ReadKey();
                        break;
                    case 8:
                        WriteLine("VII");
                        ReadKey();
                        break;
                    case 9:
                        WriteLine("IX");
                        ReadKey();
                        break;
                    case 10:
                        WriteLine("X");
                        ReadKey();
                        break;
                    default:
                        WriteLine("Sorry, too big!");
                        ReadKey();
                        break;
                }
            }
            else
            {
                WriteLine("Non valid entry.");
                ReadKey();
            }

        }
    }
    //Exercise 1 class and method end.
    //Exercise 3 class and method beginning.
    class BMI
    {
        public string weight;
        public string height;
        public double w;
        public double h;
        public void CalculateIBMI()
        {
            double ibmi = ((w / (h * h)) * 703);
            if (ibmi < 18.5)
            {
                WriteLine("Your BMI is\n" + ibmi + "\nYou are underweight.");
                ReadKey();
            }
            else if ((ibmi >= 18.5) && (ibmi <= 24.9))
            {
                WriteLine("Your BMI is\n" + ibmi + "\nYou are at a normal weight.");
                ReadKey();
            }
            else if ((ibmi >= 25) && (ibmi <= 29.9))
            {
                WriteLine("Your BMI is\n" + ibmi + "\nYou are overweight.");
                ReadKey();
            }
            else if (ibmi > 29)
            {
                WriteLine("Your BMI is\n" + ibmi + "\nYou are obese.");
                ReadKey();
            }
            else
            {
                WriteLine("Fine then, be that way.");
                ReadKey();
            }

            
        }
        public void CalculateMBMI()
        {
            double mbmi = (w / (h * h));
            if (mbmi < 18.5)
            {
                WriteLine("Your BMI is\n" + mbmi + "\nYou are underweight.");
                ReadKey();
            }
            else if ((mbmi >= 18.5) && (mbmi <= 24.9))
            {
                WriteLine("Your BMI is\n" + mbmi + "\nYou are at a normal weight.");
                ReadKey();
            }
            else if ((mbmi >= 25) && (mbmi <= 29.9))
            {
                WriteLine("Your BMI is\n" + mbmi + "\nYou are overweight.");
                ReadKey();
            }
            else if (mbmi > 29)
            {
                WriteLine("Your BMI is\n" + mbmi + "\nYou are obese.");
                ReadKey();
            }
            else
            {
                WriteLine("Fine then, be that way.");
                ReadKey();
            }


        }
        public static void InputBMI()
        {
            BMI one = new BMI();
            WriteLine("Enter 1 for Imperial or 2 for Metric");
            string choice = ReadLine();
            if (choice == "1")
            {
                WriteLine("Enter you weight in pounds:");
                one.weight = ReadLine();
                WriteLine("Enter your height in inches:");
                one.height = ReadLine();
                double.TryParse(one.weight, out one.w);
                double.TryParse(one.height, out one.h);
                one.CalculateIBMI();
            }
            else if (choice == "2")
            {
                WriteLine("Enter you weight in kilos:");
                one.weight = ReadLine();
                WriteLine("Enter your height in meters:");
                one.height = ReadLine();
                double.TryParse(one.weight, out one.w);
                double.TryParse(one.height, out one.h);
                one.CalculateMBMI();
            }
            else
            {
                WriteLine("You don't listen, you must be American lol!\nEnter you weight in pounds:");
                one.weight = ReadLine();
                WriteLine("Enter your height in inches:");
                one.height = ReadLine();
                double.TryParse(one.weight, out one.w);
                double.TryParse(one.height, out one.h);
                WriteLine("Your BMI:");
                one.CalculateIBMI();
            }
        }
    }
    //Exercise 3 class and method end.
    //Exercise 6 class and method beginning.
    class Area
    {
        public double l;
        public double w;
        public double h;
        public double r;
        string rad;
        string length;
        string width;
        string hi;

        public void AreaCircle()
        {
            double area = (22 / 7) * (r * r);
            Write("Area is: " + area);
        }
        public void AreaSquare()
        {
            double area = l * w;
            Write("Area is: "+area);
        }
        public void AreaCylinder()
        {
            double area = (2 * (22 / 7) * h) + (2 * (22 / 7) * (h * h));
            Write("Area is: " + area);
        }
        public static void AreaDisplay()
        {
            Area one = new Area();
            WriteLine("Enter 1 for circle, 2 for rectangle, 3 for cylinder, or any other key to close.");
            string area_choice = ReadLine();
            if (area_choice == "1")
            {
                WriteLine("Enter radius:");
                one.rad = ReadLine();
                double.TryParse(one.rad, out one.r);
                one.AreaCircle();
                ReadKey();
            }
            else if (area_choice == "2")
            {
                WriteLine("Enter length:");
                one.length = ReadLine();
                double.TryParse(one.length, out one.l);
                WriteLine("Enter width:");
                one.width = ReadLine();
                double.TryParse(one.width, out one.w);
                one.AreaSquare();
                ReadKey();
            }
            else if (area_choice == "3")
            {
                WriteLine("Enter height:");
                one.hi = ReadLine();
                double.TryParse(one.hi, out one.h);
                WriteLine("Enter radius:");
                one.rad = ReadLine();
                double.TryParse(one.rad, out one.r);
                one.AreaCylinder();
                ReadKey();
            }
            else
            {
                WriteLine("Goodbye! (Hit Enter)");
                ReadKey();
            }
        }
        
    }
    //Exercise 6 class and method end.
}

