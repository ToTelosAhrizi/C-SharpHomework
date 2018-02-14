using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Me a = new Me();
            WriteLine(a.My_info());
            ReadKey();

        }
    }
   
    class Me
    {
        public string My_info()
        {
            string student_num= "XX000000101";
            string student_name= "DOUGLAS HARPER";
            string student_class="SOPHMORE";
            string student_major="I.T.";
            
            return (student_num+"\n"+student_name+"\n"+student_class+"\n"+student_major);
            
        }
    }
}
    