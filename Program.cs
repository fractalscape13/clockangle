using System;
using System.Collections.Generic;
using Time;

class Program
{
  static void Main()
  {
    Console.WriteLine("Please enter a time in HR:MIN format");
    string inputTime = Console.ReadLine();
    int colonIndex = inputTime.IndexOf(":");
    string hourStr = inputTime.Substring(0, colonIndex);
    string minutesStr = inputTime.Substring(colonIndex + 1);
    int hour = int.Parse(hourStr);
    int minutes = int.Parse(minutesStr);
    Clock newClock = new Clock(hour, minutes);
    Console.WriteLine(newClock.checkDegrees());
  }
}
