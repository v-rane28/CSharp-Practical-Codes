//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//class Institues
//{
//    public void I_Name()
//    {
//        string[] str = { "Fortune Cloud","Qspider","First Bit Solution","Kiran Acedemy","Newgen Softech"};
//        Console.WriteLine("Institutes Names In Pune:");
//        for(int i=0;i<str.Length;i++)
//        {
//            Console.WriteLine((i+1)"."+str[i]);

//        }
//    }
//}
//class Fortune_Cloud:Institues
//{
//    public void F_Courses()
//    {
//        string[] Fcrs = { ".Net Full Stack", "Java Full Stack", "Python Full Stack", "MERN Stack", "DA & DS", "Cyber Security" ,"Software Testing"};
//        Console.WriteLine("Fortune Cloud Course Names:");
//        for(int i=1;i<Fcrs.Length;i++)
//        {
//            Console.WriteLine((i+1)+"."+Fcrs[i]);
//        }
//    }
//}
//class Qspider : Institues
//{
//    public void Q_Courses()
//    {
//        string[] Qcrs = { "QA Testting", "Java Full Stack", "Python Full Stack", "MERN Stack", "DA & DS", "Cyber Security" };
//        Console.WriteLine("QSpider Course Names:");
//        for (int i = 1; i < Qcrs.Length; i++)
//        {
//            Console.WriteLine((i+1) + "." + Qcrs[i]);
//        }
//    }
//    public static void Main()
//    {
//        Qspider q=new Qspider();
//
//        q.I_Name();
//     
//        q.Q_Courses();
//        Fortune_Cloud f=new Fortune_Cloud();
//        
//        f.F_Courses();
//    }
//}
