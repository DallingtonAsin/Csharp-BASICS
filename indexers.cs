// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Student
{
    private string[] students = new string[3];
    public string this[int i]{
        get{
            return students[i];
        }
        set{
            students[i] = value;
        }
    }
    
    public static void Main(string[] args)
    {
        
        Student s = new Student();
        s[0] = "Dallington";
        s[1] = "John";
        s[2] = "Peter";
        
        for(int k = 0; k<3; k++){
            Console.WriteLine(s[k]);
        }
        
    }
}