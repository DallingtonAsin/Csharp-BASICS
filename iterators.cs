using System;
using System.Collections;
using System.Collections.Generic;

public class Program: IEnumerable
{
    List<int> programCodes = new List<int>{1200, 1305, 1409};
    
    static IEnumerable<string> getMyList(List<string> list){
        foreach(string value in list){
            yield return value;
        }
    }
    
    public IEnumerator GetEnumerator(){
        
        foreach(int value in programCodes){
            yield return value;
        }
    }
    
    
    public static void Main(string[] args)
    {
       List<string> animals = new List<string>{"Cow", "Cat", "Sheep"};
       IEnumerable<string> list = getMyList(animals);
       
       Console.WriteLine("The list of animals in the list are;");
       foreach(string i in list){
           Console.WriteLine(i);
       }
       
       Console.WriteLine("The program codes are;");
       Program p = new Program();
       foreach(int x in p){
           Console.WriteLine(x);
       }
     
       
    }
}