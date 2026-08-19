//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class Pyramid
//{
//    public static void Main()
//    {
//        Pyramid p=new Pyramid();
//        p.Demo();
//        p.romanbace();
//        p.reverse_romanbace();
//    }
//    void Demo()
//    {
//        Console.WriteLine("------------------Left Angle Pyramid----------------------");
//        for(int i = 1;i<=3;i++)
//        {
//            for (int s=2;s>=i;s--)
//            {
//                Console.Write(" ");
//            }
//            for(int c=1;c<=i;c++)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }
//    }
    
//    void romanbace()
//    {
//        Console.WriteLine("------------------Romanbace----------------------");
//        int num = 0;
//        for (int i = 1; i <= 3; i++)
//        {
//            for (int s = 1; s <= i; s++)
//            {
//                Console.Write(" ");
//            }
//            for (int c = 1; c <= 3; c++)
//            {
//                Console.Write(num);
//                num++;
//            }
//            Console.WriteLine();
//        }
//    }
//    void reverse_romanbace()
//    {
//        Console.WriteLine("------------------Reverse Rombance----------------------");
//        int num = 0;
//        for (int i = 1; i <= 3; i++)
//        {
//            for (int s = 3; s >= i; s--)
//            {
//                Console.Write(" ");
//            }
//            for (int c = 1; c <= 3; c++)
//            {
//                Console.Write(num);
//                num++;
//            }
//            Console.WriteLine();
//        }

//    }
//}
