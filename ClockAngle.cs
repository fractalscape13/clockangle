using System;
using System.Collections.Generic;

class Program
{
  static void Main()
  {
    Console.WriteLine("Please enter a time in HR:MIN format");
    string inputTime = Console.ReadLine();
    int colonIndex = inputTime.IndexOf(":");
    string hour = inputTime.Substring(0, colonIndex);
    string minutes = inputTime.Substring(colonIndex + 1);
  }
}
class Clock
{

}