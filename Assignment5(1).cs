using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 
{
    abstract class student
    {


        abstract public int grade();


        public void display()
        {
            int grade;
            Console.WriteLine("Enter a grade");
            grade = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < grade; i++)
            {
                if (grade > 30)
                {
                    Console.WriteLine("pass");

                }
                else
                {
                    Console.WriteLine("fail");
                }
                Console.ReadLine();

            }
        }




    }


    class undergraduate : student
    {

        public undergraduate()
        {
            string Name;
            int id;
            Console.Write("Enter Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter id : ");
            id = Convert.ToInt16(Console.ReadLine());

        }
        public override int grade()
        {
            int number;
            Console.WriteLine("Enter a number");
            number = Convert.ToInt16(Console.ReadLine());
            string value = (number > 70) ? "TRUE" : "FALSE";
            Console.WriteLine($"{number} is {value}");
            return number;
        }

    }
    class graduate : student
    {

        public graduate()
        {
            string Name;
            int id;
            Console.Write("Enter Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter id : ");
            id = Convert.ToInt16(Console.ReadLine());

        }


        public override int grade()
        {
            int number;
            Console.WriteLine("Enter a number");
            number = Convert.ToInt16(Console.ReadLine());
            string value = (number > 80) ? "TRUE" : "FALSE";
            Console.WriteLine($"{number} is {value}");
            return number;

        }




    }
    class AbstractEg
    {
        static void Main()
        {

            student s = new undergraduate();
            Console.WriteLine(s.grade());
            student s1 = new graduate();
            Console.WriteLine(s.grade());
            s.display();

        }

    }
}

 

}