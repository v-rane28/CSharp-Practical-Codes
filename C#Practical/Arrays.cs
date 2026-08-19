//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class Arrays
//{
//    void oned_array()
//    {
//        int[] nums = { 12,13,14,15,16};
//        for(int index = 0; index<nums.Length; index++)
//        {
//            Console.WriteLine(nums[index]);
//        }
//    }
//    static void twod_array()
//    {
//        string[,] name = { { "Vaibhav","Yash"}, {"Tejas","Rushi" }, { "Om","Amol"} };
//        for(int row=0; row<name.GetLength(0); row++)
//        {
//            for(int col=0; col<name.GetLength(1); col++)
//            {
//                Console.Write(name[row,col]+" ");
//            }
//            Console.WriteLine();
//        }
//    }
//    void threed_array()
//    {
//        int[,,] num = { { {10,11 }, {12,14 } }, { { 34,23}, { 23,43} }, { { 34, 23 }, { 23, 43 } } };
//        for(int matrix=0;matrix<num.GetLength(0);matrix++)
//        {
//            for(int row=0;row<num.GetLength(1);row++)
//            {
//                for(int col=0;col<num.GetLength(2);col++)
//                {
//                    Console.Write(num[matrix,row,col]+" ");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//        }
//    }
//    public static void Main()
//    {
//        twod_array();
//        Arrays ar=new Arrays();
//        ar.oned_array();
//        ar.threed_array();

//    }
//}
