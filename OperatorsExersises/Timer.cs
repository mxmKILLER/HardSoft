using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExersises
{
    class Timer
    {
        public int Minutes
        {
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
                        value -= 60;
                    }
                    minutes = value;
                }
            }
            get
            {
                return minutes;
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

        public int Milliseconds
        {
            get
            {
                return milliseconds;
            }
            set
            {
                if (value < 1000)
                {
                    milliseconds = value;
                }
                else
                {
                    while (value >= 1000)
                    {
                        seconds++;
                        value -= 1000;
                    }
                    milliseconds = value;
                }

            }
        }

        private int minutes;

        private int seconds;

        private int milliseconds;

        public Timer()
        {
            Minutes = 0;
            Seconds = 0;
            Milliseconds = 0;
        }

        public Timer(int minutes,int seconds,int milliseconds)
        {
            Minutes = minutes;
            Seconds = seconds;
            Milliseconds = milliseconds;
        }

        public void ShowTimer()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Minutes.ToString());
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
            if (Milliseconds >= 100)
            {
                stringBuilder.Append(":");
                stringBuilder.Append(Milliseconds.ToString());
            }
            else if (Milliseconds >= 10)
            {
                stringBuilder.Append(":0");
                stringBuilder.Append(Milliseconds.ToString());
            }
            else
            {
                stringBuilder.Append(":00");
                stringBuilder.Append(Milliseconds.ToString());
            }
            Console.WriteLine(stringBuilder.ToString());
        }

        public override bool Equals(object obj)
        {
            var timer = obj as Timer;
            return timer != null &&
                   Minutes == timer.Minutes &&
                   Seconds == timer.Seconds &&
                   Milliseconds == timer.Milliseconds &&
                   minutes == timer.minutes &&
                   seconds == timer.seconds &&
                   milliseconds == timer.milliseconds;
        }

        public override int GetHashCode()
        {
            var hashCode = 1989793102;
            hashCode = hashCode * -1521134295 + Minutes.GetHashCode();
            hashCode = hashCode * -1521134295 + Seconds.GetHashCode();
            hashCode = hashCode * -1521134295 + Milliseconds.GetHashCode();
            hashCode = hashCode * -1521134295 + minutes.GetHashCode();
            hashCode = hashCode * -1521134295 + seconds.GetHashCode();
            hashCode = hashCode * -1521134295 + milliseconds.GetHashCode();
            return hashCode;
        }

        public static bool operator > (Timer timer1, Timer timer2)
        {
            int sum1 = (timer1.Minutes * 60000) + (timer1.Seconds * 1000) + timer1.milliseconds;
            int sum2 = (timer2.Minutes * 60000) + (timer2.Seconds * 1000) + timer2.milliseconds;

            return sum1 > sum2;
        }

        public static bool operator <(Timer timer1, Timer timer2)
        {
            int sum1 = (timer1.Minutes * 60000) + (timer1.Seconds * 1000) + timer1.milliseconds;
            int sum2 = (timer2.Minutes * 60000) + (timer2.Seconds * 1000) + timer2.milliseconds;

            return sum1 < sum2;
        }

        public static bool operator >=(Timer timer1, Timer timer2)
        {
            int sum1 = (timer1.Minutes * 60000) + (timer1.Seconds * 1000) + timer1.milliseconds;
            int sum2 = (timer2.Minutes * 60000) + (timer2.Seconds * 1000) + timer2.milliseconds;

            return sum1 > sum2;
        }

        public static bool operator <=(Timer timer1, Timer timer2)
        {
            int sum1 = (timer1.Minutes * 60000) + (timer1.Seconds * 1000) + timer1.milliseconds;
            int sum2 = (timer2.Minutes * 60000) + (timer2.Seconds * 1000) + timer2.milliseconds;

            return sum1 < sum2;
        }

        public static bool operator !=(Timer timer1, Timer timer2)
        {
            int sum1 = (timer1.Minutes * 60000) + (timer1.Seconds * 1000) + timer1.milliseconds;
            int sum2 = (timer2.Minutes * 60000) + (timer2.Seconds * 1000) + timer2.milliseconds;

            return sum1 != sum2;
        }

        public static bool operator ==(Timer timer1, Timer timer2)
        {
            int sum1 = (timer1.Minutes * 60000) + (timer1.Seconds * 1000) + timer1.milliseconds;
            int sum2 = (timer2.Minutes * 60000) + (timer2.Seconds * 1000) + timer2.milliseconds;

            return sum1 == sum2;
        }
    }
}
