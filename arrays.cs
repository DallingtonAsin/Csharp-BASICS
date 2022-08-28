// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Arrays
{
    public static void Main(string[] args)
    {
        
        
         // single dimensional array
        int[] numbers = new int[4]{16,29,3,4};
        Array.Sort(numbers);
        for(int k=0; k<numbers.Length; k++){
          Console.Write(numbers[k] + " ");
        }
        
        
        // dimensional array
        Console.WriteLine("\nExample of multidimensional array\n");
        int[,] nums = {{1,2,3}, {2,3,5}, {5, 9, 2}};
         for(int k=0; k<nums.GetLength(0); k++){
           for(int m=0; m<nums.GetLength(1); m++){
               Console.Write(nums[k, m] + " ");
           }
           Console.WriteLine();
        }
        
        
      // rectangular dimensional array example
        Console.WriteLine("\nExample of rectangular multidimensional array");
        string[,] names = {{"John", "Josh", "Joan"}, {"Allan","Fred","Hamson"}};
         for(int k=0; k<names.GetLength(0); k++){
           for(int m=0; m<names.GetLength(1); m++){
               Console.Write(names[k, m] + " ");
           }
           Console.WriteLine();
        }
        
        
        // jagged dimensional array
         Console.WriteLine("\nExample of rectangular multidimensional array");
        string[][] students = new string[3][];
        students[0] = new string[]{"John", "Josh"};
        students[1] =   new string[]{"Allan","Fred","Hamson"};
        students[2] =   new string[]{"Peter","Bahati","Terry"};
   
         for(int k=0; k<students.Length; k++){
           for(int m=0; m<students[k].Length; m++){
               Console.Write(students[k][m] + " ");
           }
           Console.WriteLine();
        }
        
         Console.WriteLine("\nCreating single dimensional array from Array class");
        // single dimensional array created from Array class
        Array arr = Array.CreateInstance(typeof (string), 3);
        arr.SetValue("Jimmy", 0);
        arr.SetValue("Ahmed", 1);
        arr.SetValue("Lora", 2);
        for(int m=0; m<arr.GetLength(0); m++){
               Console.Write(arr.GetValue(m) + " ");
        }
        
        Console.WriteLine("\n\nCreating multidimensional array from Array class");
         // multidimensional dimensional array created from Array class
        Array multi_arr = Array.CreateInstance(typeof (string), 2, 3);
        multi_arr.SetValue("Isaac", 0, 0);
        multi_arr.SetValue("Vivian", 0, 1);
        multi_arr.SetValue("Sarah", 0, 2);
        multi_arr.SetValue("123", 1, 0);
        multi_arr.SetValue("124", 1, 1);
        multi_arr.SetValue("125", 1, 2);
        for(int m=0; m<multi_arr.GetLength(0); m++){
               for(int k=0; k<multi_arr.GetLength(1); k++){
                 Console.Write(multi_arr.GetValue(m, k) + "\t");
              }
               Console.WriteLine();
        }
        
    Console.WriteLine("Rank of array multi_arr is {0}", multi_arr.Rank);
          
      
        
        
        
        
        
    }
}