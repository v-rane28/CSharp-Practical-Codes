using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Students
{
    int student_id;
    string name;
    string email;
    string address;
    void read()
    {
        Console.WriteLine("Student Can Read The Book...");
    }
    void walk()
    {
        Console.WriteLine("Student Can Walk....");
    }
    public static void Main()
    {
        Students s = new Students();
        s.student_id = 1;
        s.name = "Vaibhav";
        s.email = "Vaibhav@gmail.com";
        s.address = "Pandharpur";
        s.walk();
        s.read();
        Console.WriteLine("Student ID=" + s.student_id);
        Console.WriteLine("Student Name=" + s.name);
        Console.WriteLine("Student Email=" + s.email);
        Console.WriteLine("Student Address=" + s.address);
    }
}