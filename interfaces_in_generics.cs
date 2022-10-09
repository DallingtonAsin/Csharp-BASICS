
using System;

interface Person<T>{
    T eat(T meal);
    T drink(T drk);
}

public class Program: Person<string>
{
    
    public string eat(string meal){
        return meal;
    }
    
    public string drink(string d){
        return d;
    }
    
    public static void Main(string[] args)
    {
       Program p = new Program();
       Console.WriteLine("I eat "+p.eat("Rice"));
       Console.WriteLine("I drink "+p.drink("Water"));
        
    }
}