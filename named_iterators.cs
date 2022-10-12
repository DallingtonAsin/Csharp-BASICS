using System;
using System.Collections;
using System.Collections.Generic;


public class Program
{
    
    List<string> list;
    Program(List<string> list){
        this.list = list;
    }
    
    public IEnumerable GetItems(){
        foreach(string i in list){
            yield return i;
        }
    }
   
    public static void Main(string[] args)
    {
       
       Program p = new Program(new List<string>{"Peter", "John"});
       foreach(string x in p.GetItems()){
           Console.WriteLine(x);
       }
     
       
    }
}