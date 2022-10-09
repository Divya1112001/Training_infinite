using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_4_
{
    interface Istudent
    {
        string Name { get; set; }
        string id { get; set; }
        void ShowDetails();

    }
    class Dayscholar : Istudent
    {

        public string Name { get; set; }


        public int id { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine("Student name :" + Name + " " + ", and i'd is: " + id);
        }

    }
    class Resident : Istudent
    {
        string name;
        public int id { get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
           public void ShowDetails()
        {
            Console.WriteLine("Student name :" + Name + " " + ", and i'd is: " + id);
        }

    }

}
class InterfaceEg3
{
    static void Main()
    {
        Dayscholar d = new Dayscholar();
        d.Name = "harsha";
        d.id = 2;
        Resident r = new Resident();
        r.Name = "supriya";
        r.id = 6;
        Console.WriteLine(" Dayscholar Name {0}, id is {1} Resident name {2},id is {3} ", d.Name, d.id, r.Name, r.id);
        d.ShowDetails();
        r.ShowDetails();
        Console.Read();
    }
}
