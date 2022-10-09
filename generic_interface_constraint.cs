
using System;

interface IDetails{
    void getDetails();
}

class Student: IDetails{
    public int id;
    public string name;
    
    public Student(int id, string name){
        this.id = id;
        this.name = name;
    }
    
    public void getDetails(){
        Console.WriteLine("Student whose id is {0} is called {1}", this.id, this.name);
    }
}

class Generic<T> where T: IDetails{
    T[] values = new T[3];
    int counter = 0;
 
    public void Add(T val){
        if(counter < values.Length){
            values[counter] = val;
            counter++;
        }
    }
    
    public void display(){
        for(int i=0; i<3; i++){
            values[i].getDetails();
        }
    }
}

public class Program
{
    
    public static void Main(string[] args)
    {
       Program p = new Program();
       Generic<Student> std = new Generic<Student>();
       std.Add(new Student(1, "Jimmy"));
       std.Add(new Student(2, "Moses"));
       std.Add(new Student(3, "Sarah"));
       
       std.display();
        
    }
}