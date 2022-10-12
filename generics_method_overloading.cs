using System;

public class General<M, N>{
    
    public void getNumber(M x){
      Console.WriteLine("The value of type M is "+x);
    }
    
    public void getNumber(N y){
         Console.WriteLine("The value of type N is "+y);
    }
    
}

public class Program
{
    
    public static void Main(string[] args)
    {
       General<double, int> obj = new General<double, int>();
       obj.getNumber(45);
       obj.getNumber(55.5);
       
       General<string, bool> j = new General<string, bool>();
        j.getNumber("James");
        j.getNumber(true);
       
    }
}