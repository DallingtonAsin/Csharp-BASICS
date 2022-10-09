
using System;

public class Program
{
    delegate T Calculation<T>(T x, T y);
    
    static int add(int x, int y){
        return x+y;
    }
    
    static float substract(float a, float b){
        return a-b;
    }

    public static void Main(string[] args)
    {
    
    Calculation<int> calc = add;
    Calculation<float> cac = substract;
    
    int sum = calc(12, 14);
    float diff = cac(13, 8);
    Console.WriteLine("The sum is {0} and diff is {1}", sum, diff);
        
    }
}