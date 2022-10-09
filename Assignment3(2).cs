using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2_
{
    class Program
    {
         public static void Main(string[] args)
        {
            int rollNum;
            string name;
            string year;
            string branch;
            string sem;
            int[] mark = new int[5];
            int Total;
            int avg;
            string result;
            int Count = 0;
          

            void  Program(int rollNum, string name, string year, string branch, string sem)
            {
                Student s1 = new Student(1098, "Harish", "IInd year", "Computer Science", "3");
                s1.rollNum = rollNum;
                s1.name = name;
                s1.year = year;
                s1.branch = branch;
                s1.sem = sem;
                s1.Getmarks();
                s1.DisplayResult();
                s1.DisplayData();
                Console.ReadLine();

            }
            void Getmarks()
            {
                Console.WriteLine("Enter the marks");
                for (int i = 0; i < mark.Length; i++)
                {
                    Console.WriteLine("enter the marks for subject:{0} ", i + 1);
                    mark[i] = Convert.ToInt32(Console.ReadLine());
                    if (mark[i] < 35)
                    {
                        Count++;
                    }

                    Total = mark[i] + Total;
                }
                Console.WriteLine("Total of given marks : " + Total);
            }
             void DisplayResult()
            {
                avg = Total / mark.Length;

                if (Count > 0 && avg < 50)
                {
                    result = "Fail";
                }
                else
                {
                    result = "Pass";
                }


            }

            void DisplayData()
            {
                Console.WriteLine("*****student details****");
                Console.WriteLine("Roll Number: " + rollNum);
                Console.WriteLine("Student Name: " + name);
                Console.WriteLine("Year of Studying: " + year);
                Console.WriteLine("Branch: " + branch);
                Console.WriteLine("Semester: " + sem);
                Console.WriteLine("Result is: " + result);
            }

        }
    }
    }
