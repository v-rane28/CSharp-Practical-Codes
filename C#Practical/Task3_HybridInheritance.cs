//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//class Array
//{
//    public void TD_array()
//    {
//        Console.WriteLine("--------------------------2D Array....-------------------------------------------");
//        int[,] a = { { 10, 20, 30 }, { 40, 50, 60 } };
//        for (int i = 0; i < a.GetLength(0); i++)
//        {
//            for (int j = 0; j < a.GetLength(1); j++)
//            {
//                Console.Write(a[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}
//class Right_Angle:Array
//{
//    public void AngleP()
//    {
//        Console.WriteLine("--------------------------Right Angle Star Pattern...----------------------------------");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int s = 4; s > i; s--)
//            {
//                Console.Write(" ");
//            }
//            for (int c = 0; c <= i; c++)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }
//    }
//}
//class Reverse_String:Array
//{
//    public void Reverse()
//    {
//        Console.WriteLine("----------------------------Reverse String...--------------------------------");
//        string str = "Vaibhav";
//        for (int i = str.Length - 1; i >= 0; i--)
//        {
//            Console.Write(str[i]);
//        }
//        Console.WriteLine();
//    }
//}
//class Contains:Reverse_String
//{
//    public void CharC()
//    {
//        Console.WriteLine("----------------------------------Contains Code--------------------------------");
//        string str = "Welcome";
//        char k = 'e';
//        bool match = false;
//        for (int i = 0; i < str.Length; i++)
//        {
//            if (str[i] == k)
//            {
//                match = true;
//                break;
//            }
//        }
//        if (match == true)
//        {
//            Console.WriteLine("Char e Contains In String :" + str);
//        }
//        else
//        {
//            Console.WriteLine("Char e Does Not Contains In String :" + str);
//        }
//    }
//    public static void Main()
//    {
//        Contains c = new Contains();
//        c.TD_array();
//        c.Reverse();
//        c.CharC();
//        Right_Angle r=new Right_Angle();
//        r.AngleP();
//    }
//}