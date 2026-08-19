//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//class StringOpr
//{
//    public static void Main()
//    {
//        StringOpr s1 = new StringOpr();
//        s1.StringMethods();
//        s1.ContainDigit();
//        s1.Vowels();
//        Contains();
//    }
//    void StringMethods()
//    {
//        Console.WriteLine("Enter the string:");
//        string str = Console.ReadLine();
//        Console.WriteLine("String Entered By the User=" + str);
//        char[] arr = str.ToCharArray();
//        int count = 0;
//        Console.WriteLine("After The Converting String Into Array:");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.Write(arr[i] + " ");
//            count++;
//        }
//        Console.WriteLine();
//        Console.WriteLine("Count Of String=" + count);
//    }
//    void ContainDigit()
//    {
//        Console.WriteLine("Enter the string:");
//        string str = Console.ReadLine();
//        int count = 0;
//        for (int i = 0; i < str.Length; i++)
//        {
//            if (str[i] >= '0' && str[i] <= '9')
//            {
//                Console.WriteLine("String Contain Digit...");
//                count++;
//                break;
//            }
//        }
//        if (count == 0)
//        {
//            Console.WriteLine("String Does Not Contain The Digit...");
//        }
//    }
//    void Vowels()
//    {
//        Console.WriteLine("Enter The String:");
//        string name = Console.ReadLine();
//        int count = 0;
//        for (int i = 0; i < name.Length; i++)
//        {
//            if (name[i] == 'a' || name[i] == 'o' || name[i] == 'i' || name[i] == 'e' || name[i] == 'u' || name[i] == 'A' || name[i] == 'I' || name[i] == 'O' || name[i] == 'U' || name[i] == 'E')
//            {
//                Console.WriteLine("String Contains The Vowels...");
//                count++;
//                break;
//            }
//        }
//        if (count == 0)
//        {
//            Console.WriteLine("String Does Not Contain Vowels...");
//        }
//    }
//    static void Contains()
//    {
//        Console.WriteLine("Enter First String:");
//        string str1 = Console.ReadLine();

//        Console.WriteLine("Enter Second String:");
//        string str2 = Console.ReadLine();

//        int count = 0;

//        for (int i = 0; i < str1.Length; i++)
//        {
//            if (str1[i] == str2[0])
//            {
//                bool match = true;

//                for (int j = 0; j < str2.Length; j++)
//                {
//                    if (i + j >= str1.Length || str1[i + j] != str2[j])
//                    {
//                        match = false;
//                        break;
//                    }
//                }

//                if (match)
//                {
//                    count++;
//                    break;
//                }
//            }
//        }

//        // This should be outside the for loop
//        if (count > 0)
//        {
//            Console.WriteLine("String Contains " + str2);
//        }
//        else
//        {
//            Console.WriteLine("String Does Not Contain " + str2);
//        }
//    }
//}