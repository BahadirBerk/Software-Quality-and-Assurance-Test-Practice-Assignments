using System.Diagnostics;
using System;  
  public class FibonacciExample  
   {  
     public static void Main(string[] args)  
      {  
         Stopwatch stopwatch = new Stopwatch();
         stopwatch.Start();
         int n1=0,n2=1,n3,i,number;    
         Console.Write("Kaça kadar fibonacci sayısı gösterilsin? : ");    
         number = int.Parse(Console.ReadLine());  
         Console.Write(n1+" "+n2+" "); 
         for(i=2;i<number;++i)  
         {    
          n3=n1+n2;    
          Console.Write(n3+" ");    
          n1=n2;    
          n2=n3;    
         }
         stopwatch.Stop();
         Console.WriteLine("Geçen Süre:  "+stopwatch.Elapsed);
      }  
   }  