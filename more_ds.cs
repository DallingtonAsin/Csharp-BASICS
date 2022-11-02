
using System;
using System.Collections;
using System.Collections.Generic;

// Generic
public class Generic<T>{
  T[] arr;
  int counter = 0;
  
   public Generic(int max){
       arr = new T[max];
   }
   
   public void Add(T v){
       if(counter < arr.Length){
           arr[counter] = v;
           counter++;
       }
   }
   
   public void displayItems(){
       for(int i =0 ; i<arr.Length; i++){
           Console.WriteLine(arr[i]);
       }
   }
   
   
}

public class Program: IEnumerable
{
    
    
    List<string> mylist = new List<string>(){"Goat", "Sheep", "Cow"};
    List<string> items = new List<string>(){"12", "true", "Abdu"};
    
    public IEnumerator GetEnumerator(){
         foreach(var item in mylist){
             yield return item;
         }
    }
    
    public IEnumerable getMyItems(){
        foreach(var i in items){
            yield return i;
        }
    }
    
    public static void Main(string[] args)
    {
        // HashTable
        Hashtable ht = new Hashtable();
        ht.Add(1, "One");
        ht.Add(2, "Two");
        ht.Add(3, "Three");
        
        ICollection ic = ht.Keys;
        foreach(int i in ic){
            Console.WriteLine(i);
        }
        
         ICollection values = ht.Values;
         foreach(string val in  values){
            Console.WriteLine(val);
         }
         
         // SortedLists
          SortedList<int, string> sl = new SortedList<int, string>();
          sl.Add(30, "Thirty");
          sl.Add(31, "Thirty One");
          sl.Add(32, "Thirty Two");
  
     
         foreach(var v in  sl){
            Console.WriteLine(v.Key+ " "+v.Value);
         }
         
         //Stack
         Stack<int> st = new Stack<int>();
         st.Push(10);
         st.Push(11);
         st.Push(12);
         st.Push(13);
         st.Push(14);
         Console.WriteLine("Item top of the stack " + st.Peek());
    
         foreach(var item in st){
             Console.WriteLine(item);
         }
         
         Queue<string> q = new Queue<string>();
         q.Enqueue("Dallington");
         q.Enqueue("Isaac");
         q.Enqueue("Moses");
         foreach(var k in q){
             Console.WriteLine(k);
         }
         
         
         Program p = new Program();
         foreach(var x in p){
             Console.WriteLine(x);
         }
         
         
         foreach(var y in p.getMyItems()){
             Console.WriteLine(y);
         }
         
         Generic<string> ge = new Generic<string>(2);
         ge.Add("Kelly");
         ge.Add("Peter");
         ge.displayItems();
     
    }
}