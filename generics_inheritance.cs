
using System;
public class MyGeneric<P>{
    P[] values;
    int counter = 0;
    
    public MyGeneric(int max = 1){
        values = new P[max];
    }
    
    public void Add(P val){
        if(counter < values.Length){
             values[counter] = val;
             counter++;
        }
    }
    
    public void Display(){
        for(int i = 0; i<values.Length; i++){
            Console.WriteLine(values[i]);
        }
    }
    
}

public class Program: MyGeneric<string>
{
    public static void Main(string[] args)
    {
        
        MyGeneric<string> gen = new MyGeneric<string>(5);
        gen.Add("Peter");
        gen.Add("Ivan");
        
        gen.Display();
    }
}