﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_3_
{
    class libraryproject
    {
        public void CalculateConcession()
        {
            string Name;
            Console.WriteLine("Enter a Name");
            Name = Convert.ToString(Console.ReadLine());
            int AgeOfPassanger;
            double TotalFare = 500;
            Console.WriteLine("Enter  age");
            AgeOfPassanger = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < AgeOfPassanger; i++)
            {
                if (AgeOfPassanger <= 5)
                {
                    Console.WriteLine("Little Champs- Free Ticket");

                }
                else
                if (AgeOfPassanger > 60)
                {
                    TotalFare = 500 / 100 * 30;
                    Console.Write("TotalFare = {0}\n", TotalFare);
                    Console.WriteLine("senior citizen");
                }
                else
                {
                    Console.WriteLine("TotalFare: 500 ");
                    Console.WriteLine("Ticket Booked");

                }
                Console.ReadLine();

            }
        }
    }
    class program
    {

        static void Main()
        {
            libraryproject lp = new libraryproject();
            lp.CalculateConcession();

        }
    }
}
