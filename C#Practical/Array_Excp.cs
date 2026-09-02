using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Array_Excp
{
    public static void Main()
    {
        double[] nums=new double[2];
        try
        {
            nums[0] = 56.1;
            nums[1] = 33.7;
            nums[2] = 48.9;
        }
        catch
        {
            Console.WriteLine("Element Out OF the Box Exeception");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        finally
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

        }
        Console.WriteLine("Code Executed..");

    }
}
