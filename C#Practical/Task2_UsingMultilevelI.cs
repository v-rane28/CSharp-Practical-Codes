//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//class Contries
//{
//    public void C_Names()
//    {
//        string[] str = { "India", "England", "America" };
//        Console.WriteLine("Contries Names:");
//        for (int i = 0; i < str.Length; i++)
//        {
//            Console.WriteLine((i + 1) + "." + str[i]);

//        }
//    }
//}
//class States : Contries
//{
//    public void S_Names()
//    {
//        string[] Fcrs = { "Maharashtra", "Rajstan", "Uttar Pradesh", "Tamil Nadu", "Goa", "Panjab", "Jammu And Kashamir", "Karnataka" };
//        Console.WriteLine("State Names:");
//        for (int i = 0; i < Fcrs.Length; i++)
//        {
//            Console.WriteLine((i + 1) + "." + Fcrs[i]);
//        }
//    }
//}
//class Pune : States
//{
//    public void Speciality()
//    {
//        Console.WriteLine("Pune Speciality:");
//        Console.WriteLine("Pune Is Know As Education And IT Hub....");

//    }
//    public static void Main()
//    {
//        Pune p = new Pune();
//        p.C_Names();
//        Console.WriteLine("---------------------------");
//        p.S_Names();
//        Console.WriteLine("---------------------------");
//        p.Speciality();
//    }
//}
