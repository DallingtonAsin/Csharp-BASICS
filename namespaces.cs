using System;
using School;
using FoodDept = School.FoodDepartment;
// using School = School.FoodDepartment;

 namespace School{
    
    interface Exam{
        void getFinalExamDate();
    }
    
    namespace FoodDepartment{
       
        class Food{
            public void eat(){
                Console.WriteLine("Our students eat posho");
            }
            
            public void drink(){
                Console.WriteLine("Our students drink milk");
            }
        }
    }
    
    public class Student{
        
        public static void displayMarks(string name, int marks){
            Console.WriteLine("{0} scored {1}%", name, marks);
        }
        
        public void displaySchoolName(){
            Console.WriteLine("I study at ISBAT university");
        }
        
    }
}

namespace Scholarship {

public class AssessmentBoard: Exam
{
    public void getFinalExamDate(){
        Console.WriteLine("The date for final exam is on 2022-09-30");
    }
    
    public static void Main(string[] args)
    {
        // unqualified naming
        Student.displayMarks("Dallington", 90);
        Console.WriteLine ("Hello Mono World");
       
        // qualified naming
        School.Student s = new School.Student();
        s.displaySchoolName();
        
        // calling method declared in an interface in outside namespace
        AssessmentBoard a = new AssessmentBoard();
        a.getFinalExamDate();
        
        // calling nested namespace
        School.FoodDepartment.Food f = new School.FoodDepartment.Food();
        f.eat();
        
        // using namespace alias
        FoodDept.Food obj = new FoodDept.Food();
        obj.drink();
        
        //Resolving conflicting namespace alias and namespace
        // School::Food obj = new School::Food();
       // obj.drink();
    
    }
}

}