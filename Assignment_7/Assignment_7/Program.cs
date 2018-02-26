using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.Input();
        }
    }
    class Data
    {
        public string classes;
        public int cl;
        public static void Input()
        {
            Data a = new Data();
            WriteLine("How many classes?");
            a.classes = ReadLine();
            int.TryParse(a.classes, out a.cl);
            int startl = 1;
            List<string> class_list = new List<string>();
            List<int> seats = new List<int>();
            class_list.Add("Class Name   Currect enrollment   Max enrollment");
            seats.Add(0);
            while (startl <= a.cl)
            {
                WriteLine("Enter class code for class "+ startl);
                string code = ReadLine();
                WriteLine("Enter current enrollment for " + startl);
                string current = ReadLine();
                int.TryParse(current, out int c);
                WriteLine("Enter max enrollment for " + startl);
                string max = ReadLine();
                int.TryParse(max, out int m);
                string entry = (code + " " + c + " " + m);
                class_list.Add(entry);
                int space = m - c;
                seats.Add(space);
                startl++;
            }
            
            string c_list = string.Join("\n",class_list.ToArray());
            WriteLine(c_list);
            WriteLine("Which input do you want to see?");
            string input = ReadLine();
            int.TryParse(input, out int i);
            WriteLine("Number of seats left for that class is: "+ seats[i]);
            ReadKey();
        }  
    }
}
