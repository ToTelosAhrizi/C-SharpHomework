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
                    Bank a = new Bank(cus_fn, cus_ln, cus_pn, cus_bal);

                    bank.Add(a);
                }
                else if (choice.Equals("2"))
                {
                    WriteLine("Which one? enter its entry number");
                    int.TryParse(ReadLine(), out int rem);
                    bank.RemoveAt(rem-1);
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
            int index = 1;
            foreach (Bank account in bank)
            {
                WriteLine(index+". "+account.ToString());
                index++;
            }
        }
    }
    class Bank
    {
        string cus_fn;
        string cus_ln;
        string cus_pn;
        string cus_bal;
        public Bank(string cfn, string cln, string pn, string bal)
        {
            cus_fn = cfn;
            cus_ln = cln;
            cus_pn = pn;
            cus_bal = bal;
        }
        public override string ToString()
        {

            string hi =cus_fn+" "+cus_ln+" "+cus_pn+" "+cus_bal;
            return hi;
        }

    }
}
