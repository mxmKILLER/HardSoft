using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueStructEnumHomework
{
    public class Weather
    {
        private const int Months = 12;

        private const int Days = 31;

        private int[,] Year = new int[12, 31];

        public Weather()
        {
            Random rnd = new Random();
            for (int i = 0; i < Months; i++)
            {
                for (int j = 0; j < Days; j++)
                {
                    Year[i, j] = rnd.Next(0,128);
                }
            }
        }

        public void ShowClear()
        {
            int counter = 0;
            for (int i = 0; i < Months; i++)
            {
                for (int j = 0; j < Days; j++)
                {
                    Events daylyWeather = (Events)Year[i, j];   
                    if(daylyWeather.HasFlag(Events.Clear))
                    {
                        counter++;
                    }
                }   
            }
            Console.WriteLine($"{counter} of Suny days");
        }

        public void ShowFallOut()
        {
            int counter = 0;
            for (int i = 0; i < Months; i++)
            {
                for (int j = 0; j < Days; j++)
                {
                    Events daylyWeather = (Events)Year[i, j];
                    if (daylyWeather.HasFlag(Events.Rain) || daylyWeather.HasFlag(Events.Snow) || daylyWeather.HasFlag(Events.Thunderstorm))
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"{counter} of Fall-Out days");
        }

        public void ShowUndefined()
        {
            int counter = 0;
            for (int i = 0; i < Months; i++)
            {
                for (int j = 0; j < Days; j++)
                {
                    if ((Events)Year[i, j] == Events.Undefined)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"{counter} of days with unregistered weather");
        }

        public void ShowSnow()
        {
            int counter = 0;
            for (int i = 0; i < Months; i++)
            {
                for (int j = 0; j < Days; j++)
                {
                    Events daylyWeather = (Events)Year[i, j];
                    if (daylyWeather.HasFlag(Events.Snow))
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"{counter} of Snow days");
        }

        public void ShowStaticWeather()
        {
            int counter = 0;
            for (int i = 0; i < Months; i++)
            {
                for (int j = 0; j < Days; j++)
                {
                    if ((Events)Year[i, j] == Events.Clear || (Events)Year[i, j] == Events.Cloudy || (Events)Year[i, j] == Events.Fog ||
                        (Events)Year[i, j] == Events.Rain || (Events)Year[i, j] == Events.Snow || (Events)Year[i, j] == Events.Thunderstorm ||
                        (Events)Year[i, j] == Events.Windy)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"{counter} of days with static weather");
        }

        [Flags]
        private enum Events
        {
            Undefined = 0,
            Calm = 1 << 0,          //1
            Clear = 1 << 1,         //2
            Cloudy = 1 << 2,        //4
            Fog = 1 << 3,           //8
            Rain = 1 << 4,          //16
            Windy = 1 << 5,         //32
            Snow = 1 << 6,          //64
            Thunderstorm = 1 << 7,  //128
            
        }
    }
}
/*
 2) Задача на enum:

Розв'язати задачу зберігання інформації про погоду за 1 рік

Погода повинна бути представленя як битовое перечислення:
не визначено (якщо інформация не внесена), дощ, невеликий дощ, гроза, сніг, туман, хмарно, грозові хмари, ясно, вітряно, штиль и т.д.

Інформація про погоду повинна зберігатися в двовимірному масиві 12 x 31 (12 місяців X 31 день).

Програма повинна видавати інформацію:
-середня кількість сонячних днів в місяць
-загальна кількість днів в році з опадами (сніг/дощ/гроза)
і т.д. (передбачити 5 видів довідкової інформації)
*/
