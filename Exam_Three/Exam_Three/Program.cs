using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exam_Three
{
    class Program
    {
        public static  List<Bank> bank = new List<Bank>();
        static void Main(string[] args)
        {
            string con = "";
            while (con!="no" )
            {
                
                WriteLine("Press 1 to add, press 2 to delete, press 3 to display, press for to close");
                string choice = ReadLine();
                if (choice.Equals("1"))
                {
                    WriteLine("Enter First name");
                    string cus_fn = ReadLine();
                    WriteLine("Enter Last name");
                    string cus_ln = ReadLine();
                    WriteLine("Enter phone number");
                    string cus_pn = ReadLine();
                    WriteLine("Enter Balance");
                    string cus_bal = ReadLine();
                    Bank a = new Bank(cus_fn, cus_ln, cus_ln, cus_ln);

                    bank.Add(a);
                }
                else if (choice.Equals("2"))
                {
                    WriteLine("Which one? enter its entry number");
                    int.TryParse(ReadLine(), out int rem);
                    bank.RemoveAt(rem);
                }
                else if (choice.Equals("3"))
                {
                    Display_Account();
                }
                else if (choice.Equals("4"))
                {
                    con = "no";
                }
            }
            
        }
        static void Display_Account()
        {
            string hi = string.Join("\n", Program.bank.ToString());

            WriteLine(hi);
        }
    }
    class Bank
    { 
        public Bank(string cfn, string cln, string pn, string bal)
        {
            string first_name = cfn;
            string last_name = cln;
            string phone = pn;
            string balance = bal;
        }
        public override string ToString()
        {
           
            return base.ToString();
        }

    }
}
