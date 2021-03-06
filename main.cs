using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{

  public static bool binarySearch(int[]array, int search)
  {
      int middle = 0;
      uint counter = 0;
      bool find = false;
      double lowBoarder = 0, highBoarder = array.Length-1;      
      while (lowBoarder <= highBoarder)      
      {
        middle = Convert.ToInt32(Math.Truncate((lowBoarder + highBoarder) / 2));
        Console.WriteLine($"50/50: {middle}, LowBoarder: {lowBoarder}, HighBoarder: {highBoarder}.");
        counter += 1;
        if (array[middle] == search) 
        {
            Console.WriteLine($"Value: {array[middle]}, Index of array: {middle}, Counter: {counter}.");
            find = true;
        
            break;
        } else if (array[middle] < search)
            {
            
                lowBoarder = middle+1;
                continue;
                
            }  else if (array[middle] > search)
                {
                    highBoarder = middle-1;
                    continue;
                } 
      }
      
      return find;
  }  

  public static void Main()
  {
      uint number = 0;
      Console.Write($"Input numer: ");
      number = uint.Parse(Console.ReadLine());

      int[] myArray = new int[number];
      for (int i = 0; i < myArray.Length; i++)
      {
          myArray[i] = i;
      }
        /// output of array
      for (int i = 0; i < myArray.Length; i++)
      {
          if ((i % 5) == 0)
            Console.WriteLine();
          Console.Write ($"{myArray[i]}\t");
      }
      Console.WriteLine();
      
      Console.Write("Input search number: ");
      int searchNumber = int.Parse(Console.ReadLine()); 
      Console.WriteLine(binarySearch(myArray, searchNumber));   
  }
}