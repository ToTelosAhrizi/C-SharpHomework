using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            //Execise 2 Assignment 3
            WriteLine("Execise 2 Assignment 3\n");
            string x = ("*******************************************************************************************");
            string y = ("LCC is Lansing community college. It is in Lansing. The school colors are blue and silver.");
            string meter;
            string address;
            string lvalue;
            double exempt;
            double mr;
            double nvaftermr;
            double lv;
            double nv;
            double m;
            double f;
            double feet;
            double i;
            double inch;
            WriteLine(a.Sep(x));
            WriteLine(a.Info(y));
            WriteLine(a.Sep(x));
            ReadKey();
            //Execise 6 Assignment 3
            WriteLine("\nExecise 6 Assignment 3\n");
            WriteLine("Enter number of meters");
            meter = ReadLine();
            m=double.Parse(meter);
            f = 3.2808399;
            i = 39.3700787;
            feet = m * f;
            inch = m * i;
            WriteLine("There are "+f+" feet in one meter so to calculate do "+m+"*"+f);
            WriteLine("There are " + i + " inches in one meter so to calculate do " + m + "*" + i);
            WriteLine(m+" meters is "+feet+" feet and  "+inch+" inches");
            ReadKey();
            //Execise 10 Assignment 3
            WriteLine("\nExecise 10 Assignment 3\n");
            WriteLine("Enter address:");
            address = ReadLine();
            WriteLine("\nEnter last years assessed value (above $25,000):");
            lvalue = ReadLine();
            lv = double.Parse(lvalue);
            nv = lv - 25000;
            mr = .01003;
            nvaftermr = nv * mr;
            WriteLine("Your property tax is:");
            WriteLine("{0:c}",nvaftermr);

           ReadKey();
        }
        //Method 1 for execise 2
        public string Sep(string x)
        {
            return x;
        }
        //Method 2 for execise 2
        public string Info(string y)
        {
            return y;
        }
    }
}
