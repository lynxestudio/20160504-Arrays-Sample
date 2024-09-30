using System;

namespace Samples.Algol
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
   Console.WriteLine("Press enter to continue...");
   Console.ReadLine();
  }

  static void Print(int[] numbers)
  {
   Console.WriteLine();
   foreach(var item in numbers)
   {
    Console.Write(" [{0}]",item);
   }
   Console.WriteLine (Environment.NewLine);
  }
 }
}
