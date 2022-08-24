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
        
        // Boxing
        float f = 5.6F;
        Object boxed_f = f;
        Console.WriteLine("Boxed value of f is "+boxed_f+"");
        
        //Unboxing
        float unboxed = (float)boxed_f;
        Console.WriteLine("Unboxed double value of f is "+unboxed+"");
        
        // if statement
        int age = 2;
        if(age < 18){
             Console.WriteLine("A student whose age is {0} is still young", age);
        }
        
        // if-else statement
        int t = 8;
        if(t%2 == 0){
             Console.WriteLine("{0} is an even number", t);
        }else{
            Console.WriteLine("{0} is an old number", t);
        }
        
        // Nested ifs
        if(age < 18){
            Console.WriteLine("A student whose age is {0} is still young", age);
            if(age < 10){
                if(age < 3){
                    Console.WriteLine("A person who is {0} years old should be on breast milk", age);
                }else{
                   Console.WriteLine("A student of age {0} should be in a primary school", age); 
                }
            }
        }
        
        
        // Int arrays
        int[] nums = {1,2,3,4};
        int total = 0;
        for(int x=0; x<nums.Count(); x++){
            total += nums[x];
        }
        Console.WriteLine("\nSum of items in an array is "+total);
        
        // String array
        String[] names = new String[]{"Dallington", "John", "Peter"};
        foreach(String name in names){
            Console.WriteLine("{0} is part of our class", name);
        }
    }
}