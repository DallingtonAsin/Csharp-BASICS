using System;

public class Parent{
    public delegate void submitDetails();
    public event submitDetails click;
    
    public void sendDetails(){
        Console.WriteLine("Sending details now...");
    }
    
    protected void invoker(){
        Parent p = new Parent();
        p.click += new submitDetails(p.sendDetails);
        p.click();
    }
}

public class Child:Parent
{
    public static void Main(string[] args)
    {
        Child c = new Child();
        c.invoker();
    }
}