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
<<<<<<< HEAD:Program.cs
=======
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
    int minuteDegrees = minuteNum * 6;
    int hourDegrees = (hourNum * 30) + (minuteNum / 2);
    int diffDegrees = Math.Abs(hourDegrees - minuteDegrees);
    if (diffDegrees > 180)
    {
      diffDegrees = 360 - diffDegrees;
    }
    return diffDegrees;
  }
}
>>>>>>> 882253affb8e8f9fd1bd336c6c2f5daf9de16e66:ClockAngle.cs
