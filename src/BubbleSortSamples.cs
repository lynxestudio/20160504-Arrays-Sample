using System;

namespace BubbleSort
{
 class Program
 {
  public static void Main(string[] args)
  {
   int[] numbers = { 10, 84,654,42,66, 87, 3,11, 60,666};
   Console.WriteLine ("Disordered array");
   Print (numbers);
   for(int i = 0; i < numbers.Length;i++)
   {
    for(int j = i + 1;j < numbers.Length;j++)
    {
     if(numbers[j] < numbers[i])
     {
      int temp = numbers[i];
      numbers[i] = numbers[j];
      numbers[j] = temp;
     }
    }
   }
   Console.WriteLine ("Ordered array");
   Print (numbers);
  }

  static void Print(int[] numbers)
  {
   foreach(var item in numbers)
   {
    Console.Write(" [{0}]",item);
   }
   Console.WriteLine (Environment.NewLine);
  }
 }
}
