using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
     
    int len = 5;   
    int[] odds = new int[len];
    int sumOdds = 0;
    Console.WriteLine("Enter odd numbers between 7 and 15");
    for(int p=0; p<len; p++){
        int number = Convert.ToInt32(Console.ReadLine());
        if((number>=7 && number<=15) && (number % 2 == 1)){
            odds[p] = number;
            sumOdds += number;
        }else{
            Console.WriteLine("{0} is not odd number btn 7 and 15", number);
            p-=1;
        }
    }
      Console.WriteLine("Array of odd numbers between 7 and 15 are [{0}]", string.Join(",", odds));
   Console.WriteLine("The sum of odd numbers between 7 and 15 is {0}", sumOdds);
       
        Array scores = Array.CreateInstance(typeof (int), 3, 3);
        scores.SetValue(55, 0, 0);
        scores.SetValue(89, 0, 1);
        scores.SetValue(78, 0, 2);
        scores.SetValue(31, 1, 0);
        scores.SetValue(90, 1, 1);
        scores.SetValue(50, 1, 2);
        scores.SetValue(45, 2, 0);
        scores.SetValue(89, 2, 1);
        scores.SetValue(21, 2, 2);
        
        int maxEng = Convert.ToInt32(scores.GetValue(0, 0));
        int minEng = Convert.ToInt32(scores.GetValue(0, 0));
        
        int maxGeo = Convert.ToInt32(scores.GetValue(1, 0));
        int minGeo = Convert.ToInt32(scores.GetValue(1, 0));
        
        int maxBio = Convert.ToInt32(scores.GetValue(2, 0));
        int minBio = Convert.ToInt32(scores.GetValue(2, 0));
        
        double sumEng = 0, sumGeo = 0, sumBio = 0;
        double sumOfEvens = 0;
     
        
        for(int i=0; i<scores.GetLength(0); i++){
            for(int j=0; j<scores.GetLength(1); j++){
                if(i== 0 && Convert.ToInt32(scores.GetValue(i, j)) > maxEng){
                    maxEng = Convert.ToInt32(scores.GetValue(i, j));
                }
                if(i== 0 && Convert.ToInt32(scores.GetValue(i, j)) < minEng){
                    minEng = Convert.ToInt32(scores.GetValue(i, j));
                }
                
                if(i== 1 && Convert.ToInt32(scores.GetValue(i, j)) > maxEng){
                    maxGeo = Convert.ToInt32(scores.GetValue(i, j));
                }
                if(i== 1 && Convert.ToInt32(scores.GetValue(i, j)) < minEng){
                    minGeo = Convert.ToInt32(scores.GetValue(i, j));
                }
                
                if(i== 2 && Convert.ToInt32(scores.GetValue(i, j)) > maxEng){
                    maxBio = Convert.ToInt32(scores.GetValue(i, j));
                }
                if(i== 2 && Convert.ToInt32(scores.GetValue(i, j)) < minEng){
                    minBio = Convert.ToInt32(scores.GetValue(i, j));
                }
            }
        }
        
        Console.WriteLine("The maximum value in English is {0} while the minimum is {1}", maxEng, minEng);
        Console.WriteLine("The maximum value in Geography is {0} while the minimum is {1}", maxGeo, minGeo);
        Console.WriteLine("The maximum value in Biology is {0} while the minimum is {1}", maxBio, minBio);
        
        
         for(int i=0; i<scores.GetLength(0); i++){
            for(int j=0; j<scores.GetLength(1); j++){
                if(i== 0){
                    sumEng += Convert.ToInt32(scores.GetValue(i, j));
                }
                
                if(i== 1){
                    sumGeo += Convert.ToInt32(scores.GetValue(i, j));
                }
                
                if(i== 2){
                    sumBio += Convert.ToInt32(scores.GetValue(i, j));
                }
            }
        }
        
        Console.WriteLine("The sum of marks in English is {0}", sumEng);
        Console.WriteLine("The sum of marks in Geography is {0}", sumGeo);
        Console.WriteLine("The sum of marks in Biology is {0}", sumBio);

         Console.WriteLine("The average of marks in English is {0}", Math.Round(sumEng/3, 2));
        Console.WriteLine("The average of marks in Geography is {0}", Math.Round(sumGeo/3, 2));
        Console.WriteLine("The average of marks in Biology is {0}", Math.Round(sumBio/3, 2));
        
        for(int i=0; i<scores.GetLength(0); i++){
            for(int j=0; j<scores.GetLength(1); j++){
                if(Convert.ToInt32(scores.GetValue(i, j)) % 2 == 0){
                    sumOfEvens += Convert.ToInt32(scores.GetValue(i, j));
                }
            }
        }
       Console.WriteLine("The sum of even marks from all the 3 subjects is {0}", sumOfEvens); 
       
       
       
    int length = 6;
    int[] negatives = new int[length];
    Console.WriteLine("Enter negative numbers between -20 and -15");
    for(int k=0; k<length; k++){
        int num = Convert.ToInt32(Console.ReadLine());
        if(num >= -20 && num <= -15){
            negatives[k] = num;
        }else{
            Console.WriteLine("{0} has been skipped", num);
            k-=1;
        }
    }
    Console.WriteLine("Negative numbers are [{0}]", string.Join(", ", negatives));
    int[] reversedArr = new int[length];
    for(int l=negatives.Length-1; l>=0; l--){
             string formatter = ",";
             if(l == 0){
                 formatter = "";
             }
             Console.Write(negatives[l]+ ""+ formatter);
    }
    
    }
}