//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//class SingleT
//{
//    public static void Task()
//    {
//        for(int r=1;r<=4;r++)
//        {
//            for(int j=1;j<=r;j++)
//            {
//                if(r%2==0)
//                {
//                    Console.Write("@");
//                }
//                else
//                {
//                    Console.Write("*");
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//}
//class Rambous
//{
//    public static void Task1()
//    {
//        for(int i=1;i<=4;i++)
//        {
//            for (int s = 1; s <= i; s++)
//            { 
//                Console.Write(" ");
//            }
//            for(int c=1;c<=4;c++)
//            {
//                Console.Write(i);
//            }
//            Console.WriteLine();
//        }
//    }
//}
//class FInal
//{
//    public static void Main()
//    {
//        Thread t=new Thread(SingleT.Task);
//        t.Start();
//        t.Join();
//        Thread t1=new Thread(Rambous.Task1);
//        t1.Start();
//    }
//}

