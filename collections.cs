// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Program: DictionaryBase
{
    
    public void AddDetails(int id, string name){
        Dictionary.Add(id, name);
    }
    
    public void GetDetails(){
        IDictionaryEnumerator enumObj = Dictionary.GetEnumerator();
        while(enumObj.MoveNext()){
            Console.WriteLine("ID: {0} and Name: {1}", enumObj.Key, enumObj.Value);
        }
    }
    public static void Main(string[] args)
    {
        Program p = new Program();
        p.AddDetails(1, "Dallington");
        p.AddDetails(2, "John");
        p.AddDetails(3, "Peter");
        p.AddDetails(4, "Evan");
        
        p.GetDetails();
    }
}