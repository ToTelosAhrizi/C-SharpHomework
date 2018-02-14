using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Douglas_School
{
    class Program
    {
        static void Main(string[] args)
        {

            School a = new School(); //creating a new object

            WriteLine(School.AddSchool()); //Call by class and not by object because this mthod is private
            ReadKey();
            WriteLine(a.ShowSchoolInfo());
            ReadKey();
            WriteLine(School.AddSchool());
            ReadKey();
        }
    }
    class School //createing the school class that has 2 methods, AddSchool and ShowSchoolInfo
    {
        public static string AddSchool() //Set first message as variable and returned for
        {
            string x = ("School has been added\n");
            return x;
        }
        public string ShowSchoolInfo() //Public so can be called as an object instead of from class.

        /*Ask for school info and save responses as variables.
        Save one last variable as a string of text and add the variables so they can be displayed.*/
        {
            //user inputs for each school info catigory
            WriteLine("Enter school name");
            string school_name = ReadLine();

            WriteLine("Eneter school address");
            string school_address = ReadLine();

            WriteLine("Eneter school phone number");
            string school_number = ReadLine();

            WriteLine("Eneter school student count");
            string school_count = ReadLine();

            //last variable to hold all the user inputs in one space

            string school_info = ("School info below.\n\n" +
                "School Name:                      " + school_name +
                "\nSchool address:                   " + school_address +
                "\nSchool phone number:              " + school_number +
                "\nNumber of students in school:     " + school_count
                + "\n\n");

            // shows all user input data

            return school_info;
        }

    }
}
