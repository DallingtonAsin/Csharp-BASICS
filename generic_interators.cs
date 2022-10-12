using System;
using System.Collections;
using System.Collections.Generic;


class General<T>{
    List<T> list;
    public General(List<T> list){
        this.list = list;
    }
    
    public IEnumerator<T> GetEnumerator(){
        foreach(T x in list){
            yield return x;
        }
    }
    
}

public class Program
{
   
    public static void Main(string[] args)
    {
       
       General<int> numbers = new General<int>(new List<int>{12, 15, 20});
       foreach(int x in numbers){
           Console.WriteLine(x);
       }
       
       General<string> animals = new General<string>(new List<string>{"Cow", "Dog"});
       foreach(string x in animals){
           Console.WriteLine(x);
       }
     
       
    }
}