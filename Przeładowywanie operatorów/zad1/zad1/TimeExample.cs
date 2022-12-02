using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class TimeExample
    {
        private int hour, minute, second;

        public TimeExample(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public override string ToString()
        {
            return hour + ":" + minute + ":" + second;
        }

        public static bool operator == ( TimeExample left, TimeExample right)
        {
            return left.Equals(right);
        }
        public static bool operator != ( TimeExample left, TimeExample right)
        {
            return !left.Equals(right);
        }
        public static bool operator >(TimeExample left, TimeExample right)
        {
            return left.hour > right.hour;
        }
        public static bool operator <(TimeExample left, TimeExample right)
        {
            return left.hour < right.hour;
        }
        public static TimeExample operator ++(TimeExample arg)
        {
            arg.second++;
            return arg;
        }       
        public static TimeExample operator --(TimeExample arg)
        {
            arg.second--;
            return arg;
        }
    }
}
