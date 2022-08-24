// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Implicity Casting
        int a =9;
        float b = a;
        Console.WriteLine("Implicit float value of b is "+b+"");
        
        // Explicit casting
        float c = 5.6F;
        int d = (int)c;
        Console.WriteLine("Derived explicit value of d is "+d+"");
        
        int[] nums = {1,2,3,4};
        int total = 0;
        for(int x=0; x<nums.Count(); x++){
            total += nums[x];
        }
        Console.WriteLine("\nSum of items in an array is "+total);
        
        String[] names = new String[]{"Dallington", "John", "Peter"};
        foreach(String name in names){
            Console.WriteLine("{0} is part of our class", name);
        }
    }
}