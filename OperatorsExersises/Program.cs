using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExersises
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock(20,60,95);
            Clock clock2 = new Clock(20, 70, 90);

            Timer timer1 = new Timer(61, 180, 400);
            Timer timer2 = new Timer(55, 180, 1500);

            clock.ShowClock();
            clock2.ShowClock();

            timer1.ShowTimer();
            timer2.ShowTimer();


            (clock - timer1).ShowClock();
            (clock - timer2).ShowClock();

            (clock + timer1).ShowClock();
            (clock + timer2).ShowClock();

            Console.WriteLine();
        }
    }
}
