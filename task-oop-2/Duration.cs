using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_oop_2
{
   
    public class Duration
    {
    public int Hours { get; private set; }
    public int Minutes { get; private set; }
    public int Seconds { get; private set; }

    public Duration(int hours, int minutes, int seconds)
    {
        Normalize(hours * 3600 + minutes * 60 + seconds);
    }

    public Duration(int totalSeconds)
    {
        Normalize(totalSeconds);
    }

    private void Normalize(int totalSeconds)
    {
        Hours = totalSeconds / 3600;
        Minutes = (totalSeconds % 3600) / 60;
        Seconds = totalSeconds % 60;
    }

    public override string ToString()
    {
        string result = "";
        if (Hours > 0)
        {
            result += "Hours: " + Hours + ", ";
        }
        if (Hours > 0 || Minutes > 0)
        {
            result += "Minutes: " + Minutes + ", ";
        }
        result += "Seconds: " + Seconds;
        return result;
    }

    public override bool Equals(object obj)
    {
        if (obj is Duration d)
        {
            return Hours == d.Hours && Minutes == d.Minutes && Seconds == d.Seconds;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Hours, Minutes, Seconds);
    }

    public static Duration operator +(Duration d1, Duration d2)
    {
        return new Duration(d1.ToSeconds() + d2.ToSeconds());
    }

    public static Duration operator +(Duration d, int seconds)
    {
        return new Duration(d.ToSeconds() + seconds);
    }

    public static Duration operator +(int seconds, Duration d)
    {
        return d + seconds;
    }

    public static Duration operator -(Duration d1, Duration d2)
    {
        return new Duration(Math.Max(0, d1.ToSeconds() - d2.ToSeconds()));
    }

    public static Duration operator ++(Duration d)
    {
        return new Duration(d.ToSeconds() + 60);
    }

    public static Duration operator --(Duration d)
    {
        return new Duration(Math.Max(0, d.ToSeconds() - 60));
    }

    public static bool operator >(Duration d1, Duration d2)
    {
        return d1.ToSeconds() > d2.ToSeconds();
    }

    public static bool operator <(Duration d1, Duration d2)
    {
        return d1.ToSeconds() < d2.ToSeconds();
    }

    public static bool operator >=(Duration d1, Duration d2)
    {
        return d1.ToSeconds() >= d2.ToSeconds();
    }

    public static bool operator <=(Duration d1, Duration d2)
    {
        return d1.ToSeconds() <= d2.ToSeconds();
    }

    public static explicit operator DateTime(Duration d)
    {
        return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
    }

    private int ToSeconds()
    {
        return Hours * 3600 + Minutes * 60 + Seconds;
    }
}
}
