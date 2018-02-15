using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment_4_DJH
{
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
    class Student
    {
        public string fname;
        public string lname;
        public string classifaction;
        public string major;

        public Student(string first, string last, string year, string mj)
        {
            fname = first;
            lname = last;
            classifaction = year;
            major = mj;

        }


    }
    class Me
    {
        public static void Display()
        {
            Student me = new Student("First name:      Douglas", "Last name:       Harper", "Classifacation:  Sophmore", "Major:           I.T");
            WriteLine(me.fname);
            WriteLine(me.lname);
            WriteLine(me.classifaction);
            WriteLine(me.major);
            ReadKey();
        }

    }
    //Ending of Classes and Mehtods for Exercise 2 Assignment 4
    //Beginning of Classes and Mehtods for Exercise 5 Assignment 4
    class Receipt
    {
      
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
        


        public override string ToString()
        {
            double.TryParse(unit_price, out up);
            double.TryParse(quant_p, out qp);
            double total = (up * qp);
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
        public static void Input()
        {

            Receipt one = new Receipt();
            WriteLine("\nEnter Receipt Number");
            one.rn=ReadLine();
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
            WriteLine(one.ToString());
            ReadKey();

        }
    }
    //Ending of Classes and Mehtods for Exercise 5 Assignment 4
    //Beginning of Classes and Mehtods for Exercise 7 Assignment 4
    class Park
    {
        public string pname;
        public string ploc;
        public string ptype;
        public string pfac;
        public int pvis;
        public double pbug;
        public int fee;

        public string P_Info_One()
        {
            string re_one = "\nPark Info:\nPark Name\n"+ pname + "\nPark Location\n"+ ploc + "\nPark Type\n"+ptype;
            return re_one;
        }
        public string P_Info_Two()
        {
            string re_one = "\n\nMore Info:\nPark Name\n" + pname + "\nPark Location\n" + ploc + "\nPark Facilities\n" + pfac;
            return re_one;
        }
        public string P_Calc_Cost()
        {
            double cost_per_vis = pbug / pvis;
            string dis_cos = "\nCost per Visitor:\n"+ "$"+cost_per_vis;
            return dis_cos;
        }
        public string P_Calc_Rev()
        {
            double rev = pvis * fee;
            string dis_rev = "\nRevanue:\n" + "$"+rev;
            return dis_rev;
        }
        public static void P_Disp()
        {
            Park a = new Park();
            Write(a.ToString());
            ReadKey();
        }
        public override string ToString()
        {
            Park one = new Park();
            Park two = new Park();
            Park three = new Park();

            one.pname = ("YellowStone");
            one.ploc = ("U.S.A.");
            one.ptype = ("National");
            one.pfac = ("Camping");
            one.pbug = 20000000;
            one.pvis = 1000000;
            one.fee = 60;
            

            two.pname = ("Aloha");
            two.ploc = ("M.I.");
            three.ptype = ("State Park");
            two.pfac = ("Sledding");
            two.pbug = 200000;
            two.pvis = 30000;
            two.fee = 30;


            three.pname = ("Hawk Island");
            three.ploc = ("Lansing");
            three.ptype = ("County");
            three.pfac = ("Trails");
            three.pbug = 20000;
            three.pvis = 10000;
            three.fee = 0;

            return (one.P_Info_One() + one.P_Info_Two() + one.P_Calc_Cost() + one.P_Calc_Rev() +
                two.P_Info_One() + two.P_Info_Two() + two.P_Calc_Cost() + two.P_Calc_Rev() + three.P_Info_One() +
                three.P_Info_Two() + three.P_Calc_Cost() + three.P_Calc_Rev());
               
        }
        //Ending of Classes and Mehtods for Exercise 7 Assignment 4
    }
}




