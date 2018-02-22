using System;
using System.IO;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Douglas Harper, Assignment 6, Exercice 4\n\n\n");
            string again = "yes";
            while (again == "yes")
            {
                WriteLine("This program will average out the grades you input\n" +
                    "How many grades do you want to average?");
                string line = ReadLine();
                int.TryParse(line, out int lines);
                int startl = 1;
                List<double> grade = new List<double>();
                if (lines>0)
                {
                    WriteLine("Enter your grades (out of 100), make sure you have enough lines to enter\n" +
                        "(entries that are not numbers will count as 0's)");
                    while (startl <= lines)
                    {
                        Write(startl + ". ");
                        string grades = ReadLine();
                        double.TryParse(grades, out double g);
                        grade.Add(g);
                        startl++;
                    }
                    double gpa = grade.Average();
                    if (gpa >= 90)
                    {
                        WriteLine("Your grade is: " + gpa + ". You got an A");
                        WriteLine("Type yes to try again, all other entries will close:");
                        again = ReadLine();
                    }
                    else if (gpa < 90 && gpa >= 80)
                    {
                        WriteLine("Your grade is: " + gpa + ". You got an B");
                        WriteLine("Type yes to try again, all other entries will close:");
                        again = ReadLine();
                    }
                    else if (gpa < 80 && gpa >= 70)
                    {
                        WriteLine("Your grade is: " + gpa + ". You got an C");
                        WriteLine("Type yes to try again, all other entries will close:");
                        again = ReadLine();
                    }
                    else if (gpa < 70 && gpa >= 60)
                    {
                        WriteLine("Your grade is: " + gpa + ". You got an D");
                        WriteLine("Type yes to try again, all other entries will close:");
                        again = ReadLine();
                    }
                    else if (gpa < 60)
                    {
                        WriteLine("Your grade is: " + gpa + ". You got an F");
                        WriteLine("Type yes to try again, all other entries will close:");
                        again = ReadLine();
                    }
                    else
                    {
                        WriteLine("Type yes to try again, all other entries will close:");
                        again = ReadLine();
                    }

                }
                else
                {
                    WriteLine("Type yes to try again, all other entries will close:");
                    again = ReadLine();
                }
                
            }
            
        }
    }
}
