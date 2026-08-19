//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//class Second
//{
//    public static void Main()
//    {
//        Second s1=new Second();
//        s1.jugged_a();
//        s1.SecondLargest();
//        StringOpr();
//    }
//    static void StringOpr()
//    {
//        string str = " I Love .Net Framework ";
//        Console.WriteLine("Convert Into Lower Case:"+str.ToLower());
//        Console.WriteLine("Convert Into Upper Case:" + str.ToUpper());
//        Console.WriteLine("Check The It contains that word or not:" + str.Contains("love"));
//        Console.WriteLine("Check The length of the string:" + str.Length);
//        Console.WriteLine("Prints the string after the 3 index:" + str.Substring(3));
//        Console.WriteLine("Replace the i with you:" + str.Replace("I","You"));
//        Console.WriteLine("if the string is matches returns the true or false:" + str.Equals("i love .net framework"));
//        Console.WriteLine("remove the space only of stating and ending:" + str.Trim());
//        Console.WriteLine("Remove the string after the 4 index:" + str.Remove(4));
//        char[] chars = str.ToCharArray();
//        for(int i=0;i<=chars.Length;i++)
//        {
//            Console.WriteLine(chars[i]);
//        }
//        Console.WriteLine("After Manipulation:"+str);
//    }
//    void SecondLargest()
//    {
//        int[] num1 = { 10, 20, 20, 30 };
//        int large = num1[0];
//        int second = num1[0];
//        for (int i = 1; i < num1.Length; i++)
//        {
//            if (num1[i] > large)
//            {
//                second = large;
//                large = num1[i];
//            }
//            else if (num1[i] > second && num1[i] != large)
//            {
//                second = num1[i];
//            }
//        }
//        Console.WriteLine("Largest = " + large);
//        Console.WriteLine("Second Largest = " + second);
//    }
//    void jugged_a()
//    {
//        int[][] jugg = new int[3][];
//        jugg[0] = new int[] { 10, 20, 30 };
//        jugg[1] = new int[] { 11, 21, 31 };
//        jugg[2] = new int[] { 32, 42, 60,90 };
//        for(int i=0;i<jugg.Length;i++)
//        {
//            for(int j = 0; j < jugg[i].Length;j++)
//            {
//                Console.Write(jugg[i][j]+" ");
//            }
//            Console.WriteLine();
//        }
//    }
//}
