//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class EqualA
//{
//    public static void Main()
//    {
//        EqualA a=new EqualA();
//        a.Equal();
//    }
//    void Equal()
//    {
//        Console.WriteLine("Enter The Size Of 1st Array:");
//        int size1 = int.Parse(Console.ReadLine());
//        Console.WriteLine("Enter The Size Of 2nd Array:");
//        int size2 = int.Parse(Console.ReadLine());
//        if(size1==size2)
//        {
//            Console.WriteLine("Both Arrays Size IS Equal...");
//            int[] aar1 = new int[size1];
//            int[] aar2=new int[size2];
//            Console.WriteLine("Enter The Element Of 1st Array:");
//            for (int i=0;i<aar1.Length;i++)
//            {
//                aar1[i]=int.Parse(Console.ReadLine());
//            }
//            Console.WriteLine("Enter The Element Of 2nd Array:");
            
//            for (int i = 0; i < aar2.Length; i++)
//            {
//                aar2[i] = int.Parse(Console.ReadLine());
//            }
//            bool notequal=false;
//            for(int i=0;i<aar1.Length;i++)
//            {
//                if (aar1[i]!=aar2[i])
//                {
//                    notequal=true;
//                    Console.WriteLine("Both Arrays Are Not Equal...");
//                    break;
//                }
                
//            }
//            if (notequal == false)
//            {
//                Console.WriteLine("Both Arrays Are Equal...");
//            }


//        }
//        else
//        {
//            Console.WriteLine("Size Are Not Equal Of Both Array...");
//        }
//    }
//}