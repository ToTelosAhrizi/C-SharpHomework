using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Group_Assignment_1
{
    class Program
    {
        public string line;
        public int lines;        
        static void Main(string[] args)
        {            
            Input();//Prog 5
            Validate();//prog 1
                       //prog 6
        }
        public static void Input()
        {
            Program a = new Program();
            WriteLine("How many lines?");
            a.line = ReadLine();
            int.TryParse(a.line, out a.lines);
            int startl = 1;
            List<double> cost_list = new List<double>();
            WriteLine("Input price then hit enter");
            while (startl <= a.lines)
            {
                Write(startl + ". $");
                string price = ReadLine();
                double.TryParse(price, out double p);
                cost_list.Add(p);
                startl++;
            }
            double total = cost_list.Sum();
            Write("Your before shipping and tax total is: ");
            WriteLine("{0:C2}", total);
            ReadKey();
            double tax = 1.0775;
            if (a.lines<3)
            {
                double shipping = 3.5;
                double gran_total = ((total * tax) + shipping);
                WriteLine("Tax is 7.75%");
                Write("Shipping is ");
                WriteLine("{0:C2}", shipping);
                Write("Grand total is ");
                WriteLine("{0:C2}", gran_total);
                ReadKey();
            }
            else if (a.lines>3 && a.lines<= 6)
            {
                double shipping = 5;
                double gran_total = ((total * tax) + shipping);
                WriteLine("Tax is 7.75%");
                Write("Shipping is ");
                WriteLine("{0:C2}", shipping);
                Write("Grand total is ");
                WriteLine("{0:C2}", gran_total);
                ReadKey();


            }
            else if (a.lines > 6 && a.lines <= 10)
            {
                double shipping = 7; double gran_total = ((total * tax) + shipping);
                WriteLine("Tax is 7.75%");
                Write("Shipping is ");
                WriteLine("{0:C2}", shipping);
                Write("Grand total is ");
                WriteLine("{0:C2}", gran_total);
                ReadKey();
            }
            else if (a.lines > 10 && a.lines <= 15)
            {
                double shipping = 9;
                double gran_total = ((total * tax) + shipping);
                WriteLine("Tax is 7.75%");
                Write("Shipping is ");
                WriteLine("{0:C2}", shipping);
                Write("Grand total is ");
                WriteLine("{0:C2}", gran_total);
                ReadKey();
            }
            else if (a.lines > 15)
            {
                double shipping = 10;
                double gran_total = ((total * tax) + shipping);
                WriteLine("Tax is 7.75%");
                Write("Shipping is ");
                WriteLine("{0:C2}", shipping);
                Write("Grand total is ");
                WriteLine("{0:C2}", gran_total);
                ReadKey();
            }
            
        }
        public static void Validate()
        {
            Program a = new Program();
            
            
            List<string> cost_list = new List<string>();
            string again = "yes";
            while (again == "yes")
            {
                WriteLine("How many entries?");
                a.line = ReadLine();
                int.TryParse(a.line, out a.lines);
                int startl = 1;
                while (startl <= a.lines)
                {
                    Write(startl + ". ");
                    string word = ReadLine();

                    if (int.TryParse(word, out int wd) && wd >= 0 && wd <= 100)
                    {
                        cost_list.Add(wd + " Valid");
                    }
                    else if ((int.TryParse(word, out wd) && wd >= 0 || wd <= 100))
                    {
                        cost_list.Add(wd + " Non-valid");
                    }
                    else
                    {
                        cost_list.Add(word + " Non-valid");
                    }
                    
                    startl++;
                    
                }
                string group = string.Join("\n", cost_list.ToArray());
                WriteLine("\n");
                WriteLine(group);
                WriteLine("To go again, type yes. All other inputs will close");
                again = ReadLine();

            }
            


        }
    }
}
