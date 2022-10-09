
using System;
public class MyGeneric<T>{
    T[] values;
    int counter = 0;
    
    public MyGeneric(int max){
        values = new T[max];
    }
    
    public void Add(T val){
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
public class Program
{
    public static void Main(string[] args)
    {
        
        MyGeneric<string> gen = new MyGeneric<string>(5);
        gen.Add("Dallington");
        gen.Add("James");
        
        gen.Display();
        
        MyGeneric<int> obj = new MyGeneric<int>(5);
        obj.Add(45);
        obj.Add(50);
        obj.Add(51);
        obj.Add(54);
        obj.Display();
        
    }
}