// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;


public class Person{
    public int[] IDs = new int[3];
    
    public virtual int this[int i]{
        get{
            return IDs[i];
        }
        
        set{
            IDs[i] = value;
        }
    }
}

public class Student: Person
{
    
      public override int this[int index]{
        get{
            return base[index];
        }
        
        set{
            base[index] = value;
        }
      }
  
    public static void Main(string[] args)
    {
        
        Student obj = new Student();
        obj[0] = 12;
        obj[1] = 9;
        obj[2] = 10;
        
         for(int y = 0; y<3; y++){
            Console.WriteLine(obj[y]);
        }
        
        
    }
}