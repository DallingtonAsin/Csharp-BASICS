using System;

public class Program
{
    
    public static void Display<T>(T val){
        Console.WriteLine("Your value is "+val);
    }
    
    public static void Main(string[] args)
    {
        
        Display<int>(12);
        Display<string>("Dallington");
        Display<bool>(true);
        Display<float>(3.14f);
        
    }
}