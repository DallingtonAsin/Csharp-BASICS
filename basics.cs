// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;

public class HelloWorld
{
    
    static int getMyMarks(String subject){
        if(subject == "C#"){
            return 80;
        }
        return 45;
    }
    
    public static void Main(string[] args)
    {
        // Implicity Casting
        int a =9;
        float b = a;
        Console.WriteLine("Implicit float value of b is "+b+"");
        
        // Explicit casting
        float c = 5.6F;
        int d = (int)c;
        Console.WriteLine("Derived explicit value of d is "+d+"");
        
        // Boxing
        float f = 5.6F;
        Object boxed_f = f;
        Console.WriteLine("Boxed value of f is "+boxed_f+"");
        
        //Unboxing
        float unboxed = (float)boxed_f;
        Console.WriteLine("Unboxed double value of f is "+unboxed+"");
        
        // if statement
        int age = 2;
        if(age < 18){
             Console.WriteLine("A student whose age is {0} is still young", age);
        }
        
        // if-else statement
        int t = 8;
        if(t%2 == 0){
             Console.WriteLine("{0} is an even number", t);
        }else{
            Console.WriteLine("{0} is an old number", t);
        }
        
        // Nested ifs
        if(age < 18){
            Console.WriteLine("A student whose age is {0} is still young", age);
            if(age < 10){
                if(age < 3){
                    Console.WriteLine("A person who is {0} years old should be on breast milk", age);
                }else{
                   Console.WriteLine("A student of age {0} should be in a primary school", age); 
                }
            }
        }
        
        // use of switch statement
        int number = 5;
        switch(number%2){
            case 0:
            Console.WriteLine("The number {0} is even", number);
            break;
            case 1:
            Console.WriteLine("The number {0} is odd", number);
            break;
            default:
            Console.WriteLine("The number {0} is neither even nor odd", number);
            break;
        }
        
        
        // Int arrays and use of for loop
        int[] nums = {1,2,3,4};
        int total = 0;
        
        // for loop construct
        for(int x=0; x<nums.Count(); x++){
            total += nums[x];
        }
        Console.WriteLine("\nSum of items in an array is "+total);
        
        // while construct that gets sum of odd numbers from 0 to 20;
        int p = 0;
        int sum_of_odds = 0;
        while(p<=20){
            if(p%2==1){
                sum_of_odds+=p;
            }
            p++;
        }
        Console.WriteLine("Sum of odd numbers from 0 to 20 is "+sum_of_odds);
        
        
        // do while construct:  gets sum of even numbers from 10 to 20
        int sum_of_evens = 0;
        int num = 10;
          do{
              if(num%2==0){
                  sum_of_evens += num;
              }
              num++;
          }while(num<=20);
         Console.WriteLine("\nSum of even numbers from 10 to 20 is "+sum_of_evens);
        
        // String array and use of foreach
        String[] names = new String[]{"Dallington", "John", "Peter"};
        foreach(String name in names){
            Console.WriteLine("{0} is part of our class", name);
        }
        
        // use of break statement;
        int u = 1;
        while(u<20){
            Console.WriteLine("Number to be printed is {0}", u);
            if(u==12){
                break;
            }
            u++;
        }
        
        // use of continue statement
        for(int k=50; k>=30; k--){
            if(k==47){
                continue;
            }
            Console.WriteLine("Printed number is {0}", k);
        }
        
        // use of return statetement
        String subject = "C#";
        Console.WriteLine("I scored {0}% in {1}", getMyMarks(subject), subject);
        
        // Use of goto statement
        String lang = "English";
        
        if(lang == "English"){
            goto EnglishMan;
        }
        
        EnglishMan: 
          Console.WriteLine("I am an english man");
        
        
        
    }
}