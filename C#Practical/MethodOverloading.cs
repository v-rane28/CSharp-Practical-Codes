//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class MethodOverloading
//{
//    void Payment()//1.By Using No Parameter
//    {
//        Console.WriteLine("Payment Using Phone Pay");
//    }
//    void Payment(int a)//2.By using the parameter
//    {
//        Console.WriteLine("Payment Using Google Pay");
//    }
//    void Payment(string a)//3.By changing parameter data type
//    {
//        Console.WriteLine("Payment Using Paytm");
//    }
//    void Payment(int a,char b)//4.by passing diff number of parameter with diff data type or same
//    {
//        Console.WriteLine("Payment Using Slice");
//    }
//    void Payment(char c,int b)//5.by changing the sequence of the parameter
//    {
//        Console.WriteLine("Payment Using Debit Card");
//    }
//    public static void Main()
//    {
//        MethodOverloading m=new MethodOverloading();
//        m.Payment();
//        m.Payment(1);
//        m.Payment("Vaibhav");
//        m.Payment(10,'a');
//        m.Payment('a',11);
//    }
//}