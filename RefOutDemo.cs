using System;
namespace MySpace {
    
 class RefOutDemo {
   
    public static void calculate(ref int x, ref int y){
           x = x*x;
           y = y*y*y;
    }
    
    public static void calculate1(int x, int y){
           x = x*x;
           y=y*y*y;
    }
    
     public static void calculate2(out int x, out int y){
           x = 78;
           y = 90;
    }
    
        
    public static void Main(string[] args)
    {
       
    int a = 9;
    int b = 8;
    
     Console.WriteLine("Values of a and b before calling method are {0} and {1}", a, b);
   calculate1(a, b);
    Console.WriteLine("Values of a and b after calling method are {0} and {1}", a, b);
  
   Console.WriteLine("Values of a and b before calling method are {0} and {1}", a, b);
   calculate(ref a, ref b);
    Console.WriteLine("Values of a and b after calling method are {0} and {1}", a, b);
    
    int k, m;
    calculate2(out k, out m);
    Console.WriteLine("Values of k and m after calling method are {0} and {1}",  k, m);
   
    }
    }
}