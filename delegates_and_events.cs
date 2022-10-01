using System;

namespace Demo{

public class Program
{
        public delegate int Calculator(int x, int y);
        public delegate int AgeDeterminant(int age);
        public delegate double Area(double age);
        public delegate void Maths(int a, int b);
        
        public delegate void Printer();
        public event Printer Print;
        
        public void output(){
            Console.WriteLine("Printer is now printing...");
        }
    
        public static int add(int x, int y){
            return x+y;
        }
        
       public static int sum(int x, int y){
            return x-y;
        }
        
        public static void addition(int x, int y){
            Console.WriteLine("{0} + {1} is {2}", x, y, (x+y));
        }
        
       public static void subtraction(int x, int y){
            Console.WriteLine("{0} - {1} is {2}", x, y, (x-y));
        }
        
      public void multiplication(int x, int y){
            Console.WriteLine("{0} * {1} is {2}", x, y, (x*y));
        }
        
       public void division(int x, int y){
            Console.WriteLine("{0} / {1} is {2}", x, y, (x/y));
        }
        
        public int isAdult(int age){
            return (age > 18) ? 1 : 0;
        }
        
        public double AreaCircle(double r){
            double pie = 3.14;
            return pie*r*r;
        }
        
         public double AreaRectangle(double r){
            double pie = 3.14;
            return pie*r*r;
        }
    
    public static void Main(string[] args)
    {
        Program p = new Program();
        
        Calculator calc = new Calculator(add);
        int res = calc(23, 12);
        Console.WriteLine("The sum of x and y is "+res);
        
        Calculator cal = new Calculator(sum);
        int result = cal(23, 12);
        Console.WriteLine("The difference btn x and y is "+result);
        
         Area area = new Area(p.AreaCircle);
        double re = area(3);
        Console.WriteLine("The area of the circle is "+re);
        
        AgeDeterminant det = new AgeDeterminant(p.isAdult);
        int myage = 19;
        bool isOld = det(myage) == 1;
        Console.WriteLine("Is the person of {0} years old? : {1}", myage, isOld);
        
        Maths math = new Maths(addition);
        math += new Maths(subtraction);
        math += new Maths(p.multiplication);
        math += new Maths(p.division);
        
        math(30, 10);
        
        p.Print += new Printer(p.output);
        p.Print();
       
    }
}
}