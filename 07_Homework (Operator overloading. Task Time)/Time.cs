using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Homework__Operator_overloading._Task_Time_
{
    internal class Time
    {
        private const int secondsPerHours = 86400;
        private int hh;
        public int HH
        {
            get => hh;
            set { hh = (int)(value % 24); }
        }
        private int mm;
        public int MM
        {
            get => mm;
            set { mm = (int)(value % 60); }
        }
        private int ss;
        public int SS
        {
            get => ss;
            set { ss = (int)(value % 60); }
        }
        public int TotalSeconds => SS + MM * 60 + HH * 60 * 60; 
        public Time()
        {
            HH = 0;
            MM = 0;
            SS = 0;
        }
        public Time(int hours, int minutes, int seconds)
        {
            HH = hours;
            MM = minutes;
            SS = seconds;
        }
        public Time(int seconds) { SecondsToOther(seconds); }
        private void SecondsToOther(int seconds)
        {
            while (seconds < 0)
                seconds += secondsPerHours;
            SS = (short)(seconds % 60);
            seconds /= 60;
            MM = (short)(seconds % 60);
            seconds /= 60;
            HH = (short)(seconds % 24);
        }
        public override string ToString() { return $"{HH:D2}:{MM:D2}:{SS:D2}"; }
        public void Reset()
        {
            HH = (int)DateTime.Now.Hour;
            MM = (int)DateTime.Now.Minute;
            SS = (int)DateTime.Now.Second;
        }
        //#region overload
        public static Time operator ++(Time t)
        {
            t.SecondsToOther(t.TotalSeconds + 1);
            return t;
        }
        public static Time operator --(Time t)
        {
            t.SecondsToOther(t.TotalSeconds - 1);
            return t;
        }
        //---------------------------------------
        public static Time operator +(Time t1, Time t2)
        {
            Time s3 = new Time(t1.TotalSeconds + t2.TotalSeconds);
            return s3;
        }
        public static Time operator -(Time t1, Time t2)
        {
            Time s3 = new Time(t1.TotalSeconds - t2.TotalSeconds);
            return s3;
        }

        //---------------------------------------
        // Override Equals and GetHashCode
        public override bool Equals(object? obj)
        {
            return obj is Time time &&
                SS == time.SS &&
                MM == time.MM &&
                HH == time.HH;
        }
        // recommended to override GetHashCode() also
        public override int GetHashCode()
        {
            return HashCode.Combine(SS, MM, HH);
        }

        public static bool operator ==(Time t1, Time t2)
        {
            return t1.Equals(t2);
        }
        // must be defined in pair
        public static bool operator !=(Time t1, Time t2)
        {
            return !(t1 == t2);
        }
        //---------------------------------------

        public static bool operator >(Time t1, Time t2)
        {
            return t1.TotalSeconds > t2.TotalSeconds;
        }
        // must be defined in pair
        public static bool operator <(Time t1, Time t2)
        {
            return t1.TotalSeconds < t2.TotalSeconds;
        }

        public static bool operator >=(Time t1, Time t2)
        {
            return !(t1 < t2);
        }
        // must be defined in pair
        public static bool operator <=(Time t1, Time t2)
        {
            return !(t1 > t2);
        }

        //---------------------------------------
        public static bool operator true(Time t)
        {
            return t.TotalSeconds != 0;
        }
        // must be defined in pair
        public static bool operator false(Time t)
        {
            return t.TotalSeconds == 0;
        }
        public TimeOnly TimeOnly() => new TimeOnly(HH, MM, SS);
    }
}
