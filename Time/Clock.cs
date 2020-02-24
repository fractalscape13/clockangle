using System;

namespace Time
{
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
}