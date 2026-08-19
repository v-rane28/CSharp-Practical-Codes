//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class StringBuilderDemo
//{
//    public static void Main()
//    {

//        StringBuilderDemo sb=new StringBuilderDemo();
//       // sb.ReverseString();
//        //sb.Contains();
//        sb.duplicate();
//    //    StringBuilder sb=new StringBuilder("Vaibhav");
//    //    Console.WriteLine("Before Modification:"+sb);
//    //    Console.WriteLine("---------------");
//    //    sb.Append("Rane");
//    //    Console.WriteLine("After Modification:" + sb);
//    //    Console.WriteLine("After Modification:" + sb.Remove(8,4));
//    }
//    void ReverseString()
//    {
//        string str = "Muskan";
//        for(int i=str.Length-1; i>=0; i--)
//        {
//            Console.Write(str[i]);
//        }
//    }
//    void duplicate()
//    {
//        Console.WriteLine("Enter String:");
//        string str = Console.ReadLine();
//        char[] str1 = str.ToCharArray();
//        bool duplicate=false;
//        int count = 0;
//        for(int i=0;i<str.Length;i++)
//        {
//            for (int j = i + 1; j < str.Length; j++)
//            {
//                if (str1[i] == str1[j])
//                {
//                    duplicate = true;
//                    count++;
//                }
//            }
//        }
//        Console.WriteLine("Count Of Duplicate String:"+count);
//        if (duplicate == true)
//        {
//            Console.WriteLine("Duplicate Contains...");
//        }
//        else
//        {
//            Console.WriteLine("Duplicate Not Contains...");
//        }
//    }
//    void Contains()
//    {
//        Console.WriteLine("Enter A String:");
//        string str1=Console.ReadLine();
//        Console.WriteLine("Enter A Character:");
//        Char ch = char.Parse(Console.ReadLine());
//        char[] letters = str1.ToCharArray();
//        bool match=false;
//        for(int i=0;i<letters.Length;i++)
//        {
//            if(letters[i] == ch)
//            {
//                match = true;
//                break;
//            }
//        }
//        if(match==true)
//        {
//            Console.WriteLine(ch+ "Present In String...");
//        }
//        else
//        {
//            Console.WriteLine(ch+ "Not Present In String...");
//        }
//    }
//}