using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment_4_DJH
{/// <summary>
/// The home base of the program is here. All of the display classes
/// and the and their display/input methods a called here to run.
/// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            WriteLine("Douglas Harper\nExercise 2, 5, and 7 \nAssignment 4\n\n\n");
            Me.Display();//Exercise 2 for assignment 4
            Receipt.Input();//Exercise 5 for assignment 4
            WriteLine("\n");
            Park.P_Disp();//Exercise 7 for assignment 4
        }
    }
    //Beginning of Classes and Mehtods for Exercise 2 Assignment 4
    /// <summary>
    /// Here two classes were created. One called Student one called Me.
    /// In the Student class variables are declared as public so that they
    /// can be used between classes. Next is the Constructor Student. It was 
    /// parametized (meaning it has variables in the parentheses) so that
    /// when called later can pass those variable into the method and assign
    /// their value.
    /// </summary>
    class Student
    {
        public string fname;
        public string lname;
        public string classifaction;
        public string major;

        public Student(string first, string last, string year, string mj)//Creating the variables
        {
            fname = first;
            lname = last;
            classifaction = year;
            major = mj;

        }


    }
    /// <summary>
    /// The beginning of class "Me". In class me there is one method called Display. It is set to be a public static void so
    /// that it can be called to the main method without using a WriteLine or needing to create an object in the main method.
    ///Within the method Display, the first thing to be done is creating object "me" and calling the constructor "Student".
    /// When creating the constucter variables were also created. When calling it those variables were given actual values
    /// to display. Next, WriteLines are use to call the public variables in "Student", which were set to equal the variables
    /// in constructor student. Finishing off, there is a ReadKey to prevent auto closure once the program is done running.
    /// </summary>
    class Me
    {
        public static void Display()
        {
            Student me = new Student("First name:      Douglas", "Last name:       Harper", "Classifacation:  Sophmore", "Major:           I.T");//Defining the variable created in the school constructor.
            WriteLine(me.fname);
            WriteLine(me.lname);
            WriteLine(me.classifaction);
            WriteLine(me.major);
            ReadKey();
        }

    }
    //Ending of Classes and Mehtods for Exercise 2 Assignment 4
    //Beginning of Classes and Mehtods for Exercise 5 Assignment 4
    /// <summary>
    /// Here the class "Receipt" and its methods are create. Within the class the public variables are also delclared (created).
    /// The two methods are:
    /// "Input" methed to define the class variables (to assign them values), 
    /// "ToString"method being overridden to display what was input in the "Input" method.
    /// </summary>
    class Receipt
    {
      //declaring the class variables
        public string rn;//Receipt Number
        public string pd;//Purchase Date
        public string cn;//Customer Number
        public string cname;//Customer Name
        public string ca;//Customer Address
        public string cp;//Customer Phone Number
        public string inum;//Item ID
        public string id;//Item Description
        public string unit_price;//Unit Price as string
        public double up;//Unit Price as double
        public string quant_p;//Quantity Purchased as string
        public double qp;//Quantity Purchased as double
        
       /*
        * The "ToString" method is where the numbers that are required for mulitplacation are Parsed (converted)
        * and where the output display is defined.
        */

        public override string ToString()
        {
            double.TryParse(unit_price, out up);//converting the unit price from a string to a double to be multiplied.
            double.TryParse(quant_p, out qp);//converting the quantity purchased from a string to a double to be multiplied.
            double total = (up * qp);//multiplying the unit price and quantity purchased to get a total cost
            
            //The return statement tells the method "ToString" what to show when it is called (output displayed).
            return "\n" +
                   "\nReceipt Number:          " + rn + 
                   "\nPurchase Date:           " + pd+
                   "\nCustomer Number:         " + cn +
                   "\nCustomer Name:           " + cname + 
                   "\nCustomer Address:        " + ca + 
                   "\nCustomer Phone Number:   "+ cp + 
                   "\nItem ID:                 " + inum + 
                   "\nItem Description:        " + id + 
                   "\nUnit Price:              "+ up + 
                   "\nQuantity Purchased:      " + qp+ 
                   "\nTotal Cost:              " + total;
        }
        /*
         * The "Input" Method is where the user is promted for input and where the class variables are defined via ReadLine.
         * After the two string variable is called and the display is shown.
         */
        public static void Input()
        {

            Receipt one = new Receipt();//object is created to access the class variables.
            WriteLine("\nEnter Receipt Number");//User is promted for input
            one.rn=ReadLine();                  //Input defines class variable
            WriteLine("Enter Purchase Date");
            one.pd=ReadLine();
            WriteLine("Enter Customer Number");
            one.cn=ReadLine();
            WriteLine("Enter Customer Name");
            one.cname=ReadLine();
            WriteLine("Enter Customer Address");
            one.ca=ReadLine();
            WriteLine("Enter Customer Phone Number");
            one.cp=ReadLine();
            WriteLine("Enter Item ID");
            one.inum=ReadLine();
            WriteLine("Enter Item Description");
            one.id=ReadLine();
            WriteLine("Enter Unit Price");
            one.unit_price=ReadLine();
            WriteLine("Enter Quantity Purchased");
            one.quant_p=ReadLine();
            WriteLine(one.ToString());//Tostring is called
            ReadKey();//ReadKey to prevent auto-close

        }
    }
    //Ending of Classes and Mehtods for Exercise 5 Assignment 4
    //Beginning of Classes and Mehtods for Exercise 7 Assignment 4
    /// <summary>
    /// Here the class "Park" and its methods are create. Within the class the public variables are also delclared (created).
    /// The methods are:
    /// "P_Info_One" to show one set of info,
    /// "P_Info_Two" to show a second set of info,
    /// "P_Calc_Cost" to claculate and display the cost per visitor of the park,
    /// "P_Calc_Rev" to claculate and display the revenue of the park,
    /// "ToString" being overridden to give the class variables value and format how the info wil be displayed,
    /// "P_Disp" to be called to the main method so all the info id displayed. 
    /// </summary>
    class Park
    {
        //declaring class variables to be used between methods
        public string pname;
        public string ploc;
        public string ptype;
        public string pfac;
        public int pvis;
        public double pbug;
        public int fee;

        //Formats and displays info about the Park name, Location and type
        public string P_Info_One()
        {
            string re_one = "\nPark Info:\nPark Name\n"+ pname + "\nPark Location\n"+ ploc + "\nPark Type\n"+ptype;
            return re_one;
        }
        //Formats and displays info about the Park name, Location, and what they have 
        public string P_Info_Two()
        {
            string re_one = "\n\nMore Info:\nPark Name\n" + pname + "\nPark Location\n" + ploc + "\nPark Facilities\n" + pfac;
            return re_one;
        }
        //Calculates, formats and displays what it cost to run the park per visitor
        public string P_Calc_Cost()
        {
            double cost_per_vis = pbug / pvis;
            string dis_cos = "\nCost per Visitor:\n"+ "$"+cost_per_vis;
            return dis_cos;
        }
        //Calculates, formats and displays how much money the park makes in total
        public string P_Calc_Rev()
        {
            double rev = pvis * fee;
            string dis_rev = "\nRevanue:\n" + "$"+rev;
            return dis_rev;
        }
        //Calls the ToString so all of the info can be displayed
        public static void P_Disp()
        {
            Park a = new Park();
            Write(a.ToString());
            ReadKey();
        }
        //The "ToString" method is the class variables are set and where the output display is defined.         
        public override string ToString()
        {
            /*
             * Creating three objects of class "Park" so that each object can have it difrrent definitions of the same
             * class variables and diffrent display results for the same method calls.
             */
            Park one = new Park();
            Park two = new Park();
            Park three = new Park();
           
            //Defining the class variables for object "one"
            one.pname = ("YellowStone");
            one.ploc = ("U.S.A.");
            one.ptype = ("National");
            one.pfac = ("Camping");
            one.pbug = 20000000;
            one.pvis = 1000000;
            one.fee = 60;

            //Defining the class variables for object "two"
            two.pname = ("Aloha");
            two.ploc = ("M.I.");
            three.ptype = ("State Park");
            two.pfac = ("Sledding");
            two.pbug = 200000;
            two.pvis = 30000;
            two.fee = 30;

            //Defining the class variables for object "three"
            three.pname = ("Hawk Island");
            three.ploc = ("Lansing");
            three.ptype = ("County");
            three.pfac = ("Trails");
            three.pbug = 20000;
            three.pvis = 10000;
            three.fee = 0;

            //The return statement calls every method for object "one", "two", and "three" for display.
            return (one.P_Info_One() + one.P_Info_Two() + one.P_Calc_Cost() + one.P_Calc_Rev() +
                two.P_Info_One() + two.P_Info_Two() + two.P_Calc_Cost() + two.P_Calc_Rev() + three.P_Info_One() +
                three.P_Info_Two() + three.P_Calc_Cost() + three.P_Calc_Rev());
               
        }
        //Ending of Classes and Mehtods for Exercise 7 Assignment 4
    }
}




