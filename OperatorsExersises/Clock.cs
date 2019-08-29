using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExersises
{
    internal class Clock
    {
        public int Hours
        {
            set
            {
                if (value < 24)
                {
                    hours = value;
                }
                else
                {
                    while (value >= 24)
                    {
                        value -= 24;
                    }
                    hours = value;
                }
            }
            get
            {
                return hours;
            }
        }

        public int Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                if (value < 60)
                {
                    minutes = value;
                }
                else
                {
                    while (value >= 60)
                    {
                        hours++;
                        value -= 60;
                    }
                    minutes = value;
                }

            }
        }

        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                if (value < 60)
                {
                    seconds = value;
                }
                else
                {
                    while (value >= 60)
                    {
                        minutes++;
                        value -= 60;
                    }
                    seconds = value;
                }

            }
        }

        private int hours;

        private int minutes;

        private int seconds;

        public Clock()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }

        public Clock(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public void ShowClock()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Hours.ToString());
            if (Minutes >= 10)
            {
                stringBuilder.Append(":");
                stringBuilder.Append(Minutes.ToString());
            }
            else
            {
                stringBuilder.Append(":0");
                stringBuilder.Append(Minutes.ToString());
            }
            if (Seconds >= 10)
            {
                stringBuilder.Append(":");
                stringBuilder.Append(Seconds.ToString());
            }
            else
            {
                stringBuilder.Append(":0");
                stringBuilder.Append(Seconds.ToString());
            }
            Console.WriteLine(stringBuilder.ToString());
        }

        public override bool Equals(object obj)
        {
            var clock = obj as Clock;
            return clock != null &&
                   Hours == clock.Hours &&
                   Minutes == clock.Minutes &&
                   Seconds == clock.Seconds &&
                   hours == clock.hours &&
                   minutes == clock.minutes &&
                   seconds == clock.seconds;
        }

        public override int GetHashCode()
        {
            var hashCode = 1266180088;
            hashCode = hashCode * -1521134295 + Hours.GetHashCode();
            hashCode = hashCode * -1521134295 + Minutes.GetHashCode();
            hashCode = hashCode * -1521134295 + Seconds.GetHashCode();
            hashCode = hashCode * -1521134295 + hours.GetHashCode();
            hashCode = hashCode * -1521134295 + minutes.GetHashCode();
            hashCode = hashCode * -1521134295 + seconds.GetHashCode();
            return hashCode;
        }

        public static bool operator >(Clock clock1, Clock clock2)
        {
            int sum1 = (clock1.Hours * 3600) + (clock1.Minutes * 60) + clock1.Seconds;
            int sum2 = (clock2.Hours * 3600) + (clock2.Minutes * 60) + clock2.Seconds;

            return sum1 > sum2;
        }

        public static bool operator <(Clock clock1, Clock clock2)
        {
            int sum1 = (clock1.Hours * 3600) + (clock1.Minutes * 60) + clock1.Seconds;
            int sum2 = (clock2.Hours * 3600) + (clock2.Minutes * 60) + clock2.Seconds;

            return sum1 < sum2;
        }

        public static bool operator >=(Clock clock1, Clock clock2)
        {
            int sum1 = (clock1.Hours * 3600) + (clock1.Minutes * 60) + clock1.Seconds;
            int sum2 = (clock2.Hours * 3600) + (clock2.Minutes * 60) + clock2.Seconds;

            return sum1 >= sum2;
        }

        public static bool operator <=(Clock clock1, Clock clock2)
        {
            int sum1 = (clock1.Hours * 3600) + (clock1.Minutes * 60) + clock1.Seconds;
            int sum2 = (clock2.Hours * 3600) + (clock2.Minutes * 60) + clock2.Seconds;

            return sum1 <= sum2;
        }

        public static bool operator !=(Clock clock1, Clock clock2)
        {
            int sum1 = (clock1.Hours * 3600) + (clock1.Minutes * 60) + clock1.Seconds;
            int sum2 = (clock2.Hours * 3600) + (clock2.Minutes * 60) + clock2.Seconds;

            return sum1 != sum2;
        }

        public static bool operator ==(Clock clock1, Clock clock2)
        {
            int sum1 = (clock1.Hours * 3600) + (clock1.Minutes * 60) + clock1.Seconds;
            int sum2 = (clock2.Hours * 3600) + (clock2.Minutes * 60) + clock2.Seconds;

            return sum1 == sum2;
        }

        public static Clock operator +(Clock clock, Timer timer)
        {
            int newMinutes = clock.Minutes + timer.Minutes;
            int newSeconds = clock.Seconds + timer.Seconds;
            if (timer.Milliseconds >= 500)
            {
                newSeconds++;
            }
            return new Clock(clock.Hours, newMinutes, newSeconds);
        }

        public static Clock operator -(Clock clock, Timer timer)
        {
            int newMinutes;
            int newSeconds;
            int newHours = clock.Hours;
            if (clock.Minutes >= timer.Minutes)
            {
                newMinutes = clock.Minutes - timer.Minutes;
            }
            else
            {
                newHours--;
                newMinutes = (clock.Minutes + 60) - timer.Minutes;
            }
            if (clock.Seconds >= timer.Seconds)
            {
                newSeconds = clock.Seconds - timer.Seconds;
            }
            else
            {
                newMinutes--;
                newSeconds = (clock.Seconds + 60) - timer.Seconds;
            }

            if (timer.Milliseconds >= 500)
            {
                newSeconds--;
            }
            return new Clock(newHours, newMinutes, newSeconds);
        }

    }
}