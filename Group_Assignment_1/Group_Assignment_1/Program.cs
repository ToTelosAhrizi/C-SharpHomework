using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
            string again = "Yes";            
            while (again == "yes" || again == "Yes")
            {
                WriteLine("Press 1 for Amelia's group, 2 for Doug's group, 3  for Chris' group, all else to close.");
                string choice = ReadLine();
                if (choice == "1") //amelia's group
                {                   
                    WriteLine("Do you want to validate if input is between 0-100(press 1), or convert to hex(press 2)?");
                    string chtwo = ReadLine();
                    if (chtwo=="1")
                    {
                        Validate();//prog 1
                        WriteLine("\n");
                    }
                    else if (chtwo == "2")
                    {
                        Hexedecimal();//prog 6
                        WriteLine("\n");
                    }
                    else
                    {
                        WriteLine("Invalid input.\n");                        
                    }                    
                    WriteLine("Type yes to return main menue to run again, all else will close");
                    again = ReadLine();
                }
                else if (choice == "2") //doug's group
                {
                    WriteLine("Do you want to claculate the total cost of an online purchase(press 1), or calculate a gpa(press 2)?\n");
                    string chtwo = ReadLine();                   
                    if (chtwo == "1")
                    {
                        Input();//Prog 5
                        WriteLine("\n");
                    }
                    else if (chtwo == "2")
                    {
                        GPA();//prog 10
                        WriteLine("\n");
                    }
                    else
                    {
                        WriteLine("Invalid input.\n");                        
                    }
                    WriteLine("Type yes to return main menu, all else will close");
                    again = ReadLine();
                }
                else if (choice == "3")//chris' group
                {
                    WriteLine("Do you want to randomly generate numbers and see the info on them(press 1), or make a triangle(press 2)?\n");
                    string chtwo = ReadLine();
                    if (chtwo=="1")
                    {
                        RNG();//prog 3
                        WriteLine("\n");
                    }
                    else if (chtwo == "2")
                    {
                        WriteLine("Under Construction");//prog 10
                        WriteLine("\n");
                    }
                    else
                    {
                        WriteLine("Invalid input.\n");
                    }

                }
                else
                {
                    again = "no";
                }
            }                      
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
        public static void GPA()
        {
            
            string again = "yes";
            while (again == "yes")
            {
                WriteLine("This program will average out the grades you input\n" +
                    "How many grades do you want to average?");
                string line = ReadLine();
                int.TryParse(line, out int lines);
                int startl = 1;
                List<double> grade = new List<double>();
                if (lines > 0)
                {
                    
                    WriteLine("Enter you letter grade for each class (A-D or a-d), make sure you have enough lines to enter\n" +
                        "(entries that are not A-D or a-d will count as 0's)");
                    while (startl <= lines)
                    {
                        int g;
                        Write(startl + ". ");
                        string grades = ReadLine();
                        if (grades == "A" || grades == "a")
                        {
                            g = 4;
                            grade.Add(g);
                        }
                        else if (grades == "B" || grades == "b")
                        {
                            g = 3;
                            grade.Add(g);
                        }
                        else if (grades == "C" || grades == "c")
                        {
                            g = 2;
                            grade.Add(g);
                        }
                        else if (grades == "D" || grades == "d")
                        {
                            g = 1;
                            grade.Add(g);
                        }
                        else
                        {
                            g = 0;
                            grade.Add(g);
                        }
                        startl++;
                    }
                    double gpa = grade.Average();
                    Write("Your GPA is ");
                    WriteLine("{0:n}",gpa);
                    WriteLine("To go again, type yes. All other inputs will close");
                    again = ReadLine();
                }
                    

            }
        }
        public static void Hexedecimal()
        {
            
            
            
            string again = "yes";
            while (again == "yes")
            {
                WriteLine("This program will convert input to hex\n" +
                    "How many inputs?");
                string line = ReadLine();
                int.TryParse(line, out int lines);
                int startl = 1;
                List<string> convert = new List<string>();
                if (lines > 0)
                {

                    WriteLine("Enter what you want converted:");
                    while (startl <= lines)
                    {
                        
                        Write(startl + ". ");
                        byte[] hex = Encoding.Default.GetBytes(ReadLine());
                        var hexString = BitConverter.ToString(hex);
                        convert.Add(hexString);
                        startl++;
                    }
                    string hexout = string.Join(",\n",convert.ToArray());
                    WriteLine(hexout);
                    WriteLine("Type yes to go again, all else will close:");
                    again =ReadLine();
                }
                else
                {
                    WriteLine("Invalid entry. Type yes to try again, all else will close:");
                    again = ReadLine();
                }
            }

        }
        public static void RNG()
        {
            string again = "yes";
            while (again == "yes")
            {
                int nunum;
                int counter = 1;
                int odd_counter = 0;
                int min = 100000;
                int max = 0;
                Random r = new Random();
                while (counter < 1000)
                {
                    nunum = r.Next(0, 100000);
                    if (nunum % 2 == 0)
                    {
                        counter++;
                    }
                    else
                    {
                        counter++;
                        odd_counter++;
                    }
                    if (min > nunum)
                    {
                        min = nunum;
                    }
                    if (max < nunum)
                    {
                        max = nunum;
                    }

                }
                MessageBox.Show("Total amout of odd numbers: " + odd_counter + "\nMax number is: " + max + "\nMin number is: " + min);
                WriteLine("Type yes to go again, all else will return to main menu:");
                again = ReadLine();
            }
        }
        
    }
}
