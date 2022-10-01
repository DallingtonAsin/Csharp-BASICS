using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        ArrayList mylist = new ArrayList();
        mylist.Add("Dallington");
        mylist.Add("Peter");
        mylist.Add(500);
        mylist.Add(5.5);
        mylist.Add(true);
        mylist.Add("John");
        mylist.Add(false);
        mylist.Add(600);
        mylist.Add(8000005);
        
        Console.WriteLine("Capacity of the array is "+mylist.Capacity);
        Console.WriteLine("Count of the array is "+mylist.Count);
        Console.WriteLine("Index of 500 in the array is "+mylist.IndexOf(500));
        mylist.Remove(600);
        mylist.Remove("John");
        Console.WriteLine("Count of the array is "+mylist.Count);
        
        for(int i=0; i<mylist.Count; i++){
            Console.WriteLine(mylist[i]);
        }
        
        mylist.Clear();
        Console.WriteLine("Count of the array is "+mylist.Count);
        
    }
}