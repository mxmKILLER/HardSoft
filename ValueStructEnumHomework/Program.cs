using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueStructEnumHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Date date1 = new Date { Year = 999, Month = 2 };
            //Date date2 = new Date { Year = 1111, Month = 2 };
            //Date date3 = new Date { Year = 2000, Month = 1 };

            //DateCompare.CompareDate(date1);
            //DateCompare.CompareDate(date2);
            //DateCompare.CompareDate(date3);

            //Weather weather = new Weather();
            //weather.ShowClear();
            //weather.ShowFallOut();
            //weather.ShowUndefined();
            //weather.ShowSnow();
            //weather.ShowStaticWeather();

            //HanoiTower hanoiTower = new HanoiTower();

            //hanoiTower.Show();

            //hanoiTower.TransferDisks(4, hanoiTower.TowerSet[0], hanoiTower.TowerSet[1], hanoiTower.TowerSet[2]);

            //hanoiTower.Show();

            ArrHomework arrHomework = new ArrHomework();
            arrHomework.ShowArray();
            arrHomework.SerchForMaxInARow();
            arrHomework.SerchForMinInAColumn();
           
            Console.WriteLine();
        }
    }
}
