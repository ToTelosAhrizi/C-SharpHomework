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
    /// <summary>
    /// The home base of the program is here. All of the display classes
    /// and the and their display/input methods a called here to run.
    /// </summary>
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
    /// <summary>
    /// Here two classes were created. One called "RoNumDis" and one called "RoNumInput".
    /// In the "RoNumDis" class object one is created as an istance of class "RoNumInput".
    /// It displays everything in "RoNumInput" and is called by the main method. In class 
    /// "RoNumDis" there is one method called "Display". It is set to be a public static void so
    /// that it can be called to the main method without using a WriteLine or needing to create
    /// an object in the main method. Within the method Display, the first thing to be done is
    /// creating object "one" as an instance of class "RoNumInput". Next the method "Input"
    /// method created in "RoNumInput" is called. 
    /// </summary>
    class RoNumDis
    {
        public static void Display()
        {
            RoNumInput one = new RoNumInput();
            one.Input();
        }
    }
    /// <summary>
    /// The beginning of class "RoNumInput". Within it  is the method "Input", which allows a user to
    /// input a number and depeneding on what is entered either a roman numeral is displayed. Finishing
    /// off, there is a ReadKey to prevent auto closure once the program is done running.
    /// </summary>
    class RoNumInput
    {
        public void Input()//set to void so no return statement is needed.
        {
            string number; //declared string number for user input
            int num;       //declared int num for conversion
            WriteLine("Enter your number:"); //ask for user input 
            number = ReadLine();             //defined input as variable "number"
            /*
             * Next is an if statment to decide whether or not the input is valid is not.
             * Within the if argument there is a Try.Parse to convert the string to an int,
             * but if a non integer is entered it will not parse correctly. In short if a valid
             * int is entered it will enter the switch statement. If not it will display the error.
             */
            if (int.TryParse(number, out num))//if statement to decide whether input was an actual number
            {
                switch (num)//what to do if input is valid(is an int)
                    //cases are roman numerals up to ten and an error message if higher than that.
                {
                    case 0:
                        WriteLine("Umm...0 i think.");
                        ReadKey();
                        break;
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
            else//what to do if non int is input by user.
            {
                WriteLine("Non valid entry.");
                ReadKey();
            }

        }
    }
    //Exercise 1 class and method end.
    //Exercise 3 class and method beginning.
    /// <summary>
    /// Here we have the BMI class. Within it class variables are declared so that they can be used between methods.
    /// This class hold 3 methods:
    /// CalculateIBMI, which calculates bmi using the imperial system then displays BMI info based on input.
    /// CalculateMBMI, which calculates bmi using the metric system then displays BMI info based on input.
    /// InputBMI, allows people to enter what system they what they want to use (imperial or metric), enter their 
    /// height and weight, then call the mehtod to calculate bmi in the method the selected.
    /// </summary>
    class BMI
    {
        //declaring public variables to be used between methods
        public string weight;
        public string height;
        public double w;
        public double h;
        //Calculates bmi in the imperial system unsing user input, then formats and display's bmi info. 
        //Uses if else statements to decide what the bmi info is and what to display to show 
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
            else//if they do not enter anything to calculate their bmi
            {
                WriteLine("Fine then, be that way.");
                ReadKey();
            }

            
        }
        //Calculates bmi in the metric system unsing user input, then formats and display's bmi info.
        //Uses if else statements to decide what the bmi info is and what to display to show 
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
            else//if they do not enter anything to calculate their bmi
            {
                WriteLine("Fine then, be that way.");
                ReadKey();
            }


        }
        /*
         * Next create method "Input BMI". Within a new insance of object "BMI" called "one" is created. Then
         * the user is promted for input. Depending on the user input their hight and weight and either method 
         * "CalculateIBMI" or "CalculateMBMI" is called.
         */
        public static void InputBMI()
        {
            BMI one = new BMI();//new object "one" created
            WriteLine("Enter 1 for Imperial or 2 for Metric");// promted for user input
            string choice = ReadLine();//variable "choice" is declared and defined
            if (choice == "1")//set parameters for what to do if the user inputs "1" as choice.
            {
                WriteLine("Enter you weight in pounds:");
                one.weight = ReadLine();
                WriteLine("Enter your height in inches:");
                one.height = ReadLine();
                double.TryParse(one.weight, out one.w);//converting user input from string to double for calculations
                double.TryParse(one.height, out one.h);
                one.CalculateIBMI();
            }
            else if (choice == "2")//set parameters for what to do if the user inputs "2" as choice.
            {
                WriteLine("Enter you weight in kilos:");
                one.weight = ReadLine();
                WriteLine("Enter your height in meters:");
                one.height = ReadLine();
                double.TryParse(one.weight, out one.w);
                double.TryParse(one.height, out one.h);
                one.CalculateMBMI();
            }
            else//set parameters for what to do if the user inputs an unlisted choice.
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
    /// <summary>
    /// Here we have the "Area" class. Within it class variables are declared so that they can be used between methods.
    /// This class hold 4 methods:
    /// "AreaCircle", that will calculate the area of a circle.
    /// "AreaSquare", that will calculate the area of a square.
    /// "AreaCylinder", that will calculate the sruface area of a cylinder.
    /// "AreaDisplay", that will take user input to choose what they want to calculate, then take their input to define
    /// the public variables, call the method of there choice (choosen in the first method) then use the users definitions
    /// of the public variables to calculate the area.
    /// </summary>
    class Area
    {
        //public class variables are defined to be used between methods
        public double l;
        public double w;
        public double h;
        public double r;
        string rad;
        string length;
        string width;
        string hi;

        public void AreaCircle()//calculates area of a circle, then formats and displays the area
        {
            double area = (22 / 7) * (r * r);
            Write("Area is: " + area);
        }
        public void AreaSquare()//calculates area of a square, then formats and displays the area
        {
            double area = l * w;
            Write("Area is: "+area);
        }
        public void AreaCylinder()//calculates area of a cylinder, then formats and displays the area
        {
            double area = (2 * (22 / 7) * h) + (2 * (22 / 7) * (h * h));
            Write("Area is: " + area);
        }
        /*
         * Takes user input for what to calculate, takes user input for dementions used in calculations, 
         * then calls methods to run calculations and display outputs.
         */
        public static void AreaDisplay()
        {
            Area one = new Area();//new instance of class "Area" created and called one.
            WriteLine("Enter 1 for circle, 2 for rectangle, 3 for cylinder, or any other key to close.");//Promped user for choice
            string area_choice = ReadLine();//takes user input
            //if statement used to decide what to do depending on user choice
            if (area_choice == "1")//what to do if user inputs "1" as choice
            {
                WriteLine("Enter radius:");
                one.rad = ReadLine();
                double.TryParse(one.rad, out one.r);//converts input from strnig to double for calculations in the method call
                one.AreaCircle();
                ReadKey();
            }
            else if (area_choice == "2") //what to do if user inputs "2" as choice
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
            else if (area_choice == "3")//what to do if user inputs "3" as choice
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
            else//what to do if user inputs anything other than the three listed options as choice 
            {
                WriteLine("Goodbye! (Hit Enter)");
                ReadKey();
            }
        }
        
    }
    //Exercise 6 class and method end.
}

