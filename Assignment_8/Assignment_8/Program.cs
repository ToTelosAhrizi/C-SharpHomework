using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            LabelMaker.Maker();
            ReadKey();
        }
    }
    class LabelMaker
    {
        public static void Maker()
        {
            WriteLine("Enter your first and last name, seperated by space");
            string fullName = ReadLine();
            string[] name = fullName.Split(' ');
            string firstName = name[0];
            string lastName = name[1];
            WriteLine("Enter your birthday in the following format (mm/dd/yyyy)");
            string birthDate = ReadLine();
            string bd = Convert.ToDateTime(birthDate).ToString("MM/dd/yyyy");
            string[] barray = bd.Split('/');
            string month= barray[0];
            string day = barray[1];
            string year = barray[2];
            WriteLine("Enter the month you bought you subscription in the following format (mmm)");
            string ThisDate = ReadLine();
            string dt;
            if (ThisDate.Contains("/")|| ThisDate.Contains(" ") || ThisDate.Contains(".") || ThisDate.Contains("-") || ThisDate.Contains("_"))
            {
                dt = Convert.ToDateTime(ThisDate).ToString("MMM");
            }
            else
            {
                dt = ThisDate.Substring(0, 3);                
            }
            WriteLine("Your Zipcode");
            string zipCode="";
            int zc;
            while (zipCode == "")
            {
                zipCode = ReadLine();
                if (zipCode.Length == 5 && int.TryParse(zipCode, out zc))
                {                    
                    string trueZip = zc.ToString().Substring(3, 2);                 
                    WriteLine("\n\nHere is your stamp:");
                    WriteLine(lastName + "\n" + year + "\n" + firstName.Count() + "\n" + dt.ToUpper() + "\n" + trueZip);
                }
                else
                {
                    WriteLine("Try again");
                    zipCode = "";
                }
                
            }
        }
    }
}
