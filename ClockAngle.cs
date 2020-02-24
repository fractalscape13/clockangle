using System;
using System.Collections.Generic;

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
class Clock
{
  public int hourNum;
  public int minuteNum;
  public Clock(int hour, int minute)
  {
    hourNum = hour;
    minuteNum = minute;
  }
  public int checkDegrees()
  {
    int hourDegrees = hourNum * 30;
    int minuteDegrees = minuteNum * 6;
    int diffDegrees = Math.Abs(hourDegrees - minuteDegrees);
    if (diffDegrees > 180)
    {
      diffDegrees = 360 - diffDegrees;
    }
    return diffDegrees;
  }
}