//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class Parent
//{
//    public void Sales()
//    {
//        Console.WriteLine("Sale On Amazon And Flipkart...");
//    }
//}
//class Amazon:Parent
//{
//    public void Amazon_Sale()
//    {
//        Console.WriteLine("50% Sale On Amazon...");
//    }
//}
//class Flipkart:Parent
//{
//    public void Flipkart_Sale()
//    {
//        Console.WriteLine("50% Sale On Flipkart...");
//    }
//}
//class Flipkart_Pay:Flipkart
//{
//    void pay()
//    {
//        Console.WriteLine("Pay Using Flipkart Pay For Get Discount...");
//    }
//    public static void Main()
//    {
//        Flipkart_Pay p=new Flipkart_Pay();
//        p.Sales();
//        p.Flipkart_Sale();
//        p.pay();
//        Amazon a=new Amazon();
//        a.Amazon_Sale();
//    }
//}
