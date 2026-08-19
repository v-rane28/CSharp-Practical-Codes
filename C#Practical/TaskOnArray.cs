//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class Task
//{
//    void task1()
//    {
//        int[] num;
//        Console.WriteLine("Enter A Size Of Array:");
//        int size=int.Parse(Console.ReadLine());
//        Console.WriteLine("Enter Array Elements:");
//        num = new int[size];
//        for(int i=0;i< size;i++)
//        {
//            num[i]=int.Parse(Console.ReadLine());
//        }
//        Console.WriteLine("Array Elements:");
//        for(int i=0;i< size; i++)
//        {
//            Console.WriteLine(num[i]);
//        }
//    }
//    void task2()
//    {
//        int[] num;
//        Console.WriteLine("Enter A Size Of Array:");
//        int size = int.Parse(Console.ReadLine());
//        Console.WriteLine("Enter Array Elements:");
//        num = new int[size];
//        for (int i = 0; i < size; i++)
//        {
//            num[i] = int.Parse(Console.ReadLine());
//        }
//        int sum = 0;

//        for (int i = 0; i < size; i++)
//        {
//            sum = sum + num[i];
//        }

//        Console.WriteLine("Addition of array = " + sum);
//    }
//    void task3()
//    {
//        double[] num = {65.2,39.7,86.4};
//        for (int i = 0;i< num.Length;i++)
//        {
//            Console.WriteLine(num[i]);
//        }
//    }
//    public static void Main()
//    {
//        Task t1 = new Task();
//        //t1.task1();
//        t1.task2();
//    }
//}
