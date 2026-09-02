using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CollectionF
{
    public static void Main()
    {
        ArrayList al=new ArrayList();
        al.Add(1);
        al.Add("Vaibhav");//Add Method is Used for the add elements in the ArrayList
        al.Add("Pune");
        al.Add(82.00);
        Console.WriteLine("Data In The ArrayList:");
        // the count is the method used for the get count of the arrayList element
        
        //al.Count;
        al.Insert(2,123);//Insert the value at specific position
        al.Add(23);//
        for (int i = 0; i < al.Count; i++)
        {
            Console.WriteLine(al[i]);
        }
        Console.WriteLine("Index Of the element:"+al.IndexOf(123));// check the on which index number store that element 
        al.Remove(23);// remove the element that 23
        al.RemoveAt(3);//  remove the element on 3 index position
        al.Contains("Vaibhav"); // it checks the vaibhav string is present or not in arraylist 
        al.Clear();// remove the all the data from the arraylist

    }
}
