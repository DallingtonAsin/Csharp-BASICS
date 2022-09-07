// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
namespace Inheritance{
    
public class GrandFather{
    public virtual void moves(){
        Console.WriteLine("I can move");
    }
      protected void eat(){
          Console.WriteLine("I can eat");
      }
      
}

sealed class Mother{
    public int age = 50;
    public Mother(){
        Console.WriteLine("I am "+age+" years old");
    }
}

public class Father: GrandFather{
      public Father(){
          Console.WriteLine("I am your father");
      }
      
      public Father(string name){
          Console.WriteLine("I am called "+name);
      }
      public sealed override void moves(){
          Console.WriteLine("I can move");
      }
      protected void jumps(){
          Console.WriteLine("I can jump");
      }
      internal void getMyAge(){
          Console.WriteLine("I am 40 years old");
      }
      
      public virtual void printMyWeight(){
          Console.WriteLine("Me, your father weighs 40 kg");
      }
      
      
}

public class Son: Father
{
      
      public Son(){
          
      }
      
      public Son(string name):base("Dallington"){
          Console.WriteLine("I am called "+name);
      }
      
      new void jumps(){
          Console.WriteLine("My son can jump");
      }
     
      void canJump(){
         base.jumps();
     }
     
      public override void printMyWeight(){
          Console.WriteLine(" I weigh 20 kg");
      }
      
      public override void moves(){
          Console.WriteLine("Me, the son can move");
      }
     
    /*new int getMyAge(){
            Console.WriteLine("I am 20 years old");
    }*/
      
    public static void Main(string[] args)
    {
        Son son = new Son();
        Father f = new Father();
       
        f.moves();
        son.eat();
        
        son.canJump();
        son.jumps();
        
        son.getMyAge();
        Son s = new Son("Hamson");
        
        f.printMyWeight();
        s.printMyWeight();
        
        Mother m = new Mother();
        int myage = m.age;
        
        
    }
}

}