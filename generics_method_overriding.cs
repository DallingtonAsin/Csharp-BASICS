using System;

public class General<T>{
    
    public virtual void getValue(T x){
      Console.WriteLine("The value of type M is "+x);
    }
}

public class ValueSystem<T>: General<T>{
    
    public override void getValue(T x){
        Console.WriteLine("The value from value system is {0}", x); 
    }
    
}

public class Program
{
    
    public static void Main(string[] args)
    {
       ValueSystem<int> obj = new ValueSystem<int>();
       obj.getValue(5);
       
      ValueSystem<float> f = new ValueSystem<float>();
       f.getValue(2.5f);

       ValueSystem<string> h = new ValueSystem<string>();
       h.getValue("Dallington");
     
       
    }
}