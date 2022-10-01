// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;


public class Student
{
   public string[,] student_details = new string[4, 2];
   public string this[int pos, int col]{
       get{
           return student_details[pos, col];
       }
       
       set{
           student_details[pos, col] = value;
       }
   }
 
    public static void Main(string[] args)
    {
        
        Student obj = new Student();
        
        string[] id = new string[3]{"1000", "1001", "1002"};
        string[] names = new string[3]{"Dallington", "John", "Peter"};
        
        int counter = 0;
        for(int i = 0; i<3; i++){
            for(int j = 0; j<1; j++){
              obj[i, j] = id[counter];
              obj[i, j+1] = names[counter++];
            }
        }
        
       for(int i = 0; i<4; i++){
            for(int j = 0; j<2; j++){
              Console.WriteLine(obj[i, j]);
            }
        }
        
        
    }
}