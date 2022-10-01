// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

interface Person{
    
     public string this[int x]{
         set;
         get;
     }
}

public class Student: Person
{
  
  public string[] names = new string[2];
   public string this[int index]{
       get{
           return names[index];
       }
       
       set{
           names[index] = value;
       }
   }
 
    public static void Main(string[] args)
    {
        
        Student obj = new Student();
        obj[0] = "Dallington";
        obj[1] = "Asingwire";
        
        for(int i = 0; i<2; i++){
           Console.WriteLine(obj[i]);
        }
        
        
    }
}