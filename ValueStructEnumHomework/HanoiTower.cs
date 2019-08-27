using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueStructEnumHomework
{
    public class HanoiTower
    {
        private const int DIMENTION_1 = 3;

        private const int DIMENTION_2 = 6;

        private const int NAME_POSITION = 5;

        public Disks[][] TowerSet { get; set; } = new Disks[DIMENTION_1][];

        public HanoiTower()
        {
            for (int i = 0; i < DIMENTION_1; i++)
            {
                TowerSet[i] = new Disks[DIMENTION_2];
                for (int j = 0; j < DIMENTION_2; j++)
                {
                    if (i == 0)
                    {
                        TowerSet[i][j] = (Disks)j + 1;
                    }
                }
            }
            TowerSet[0][NAME_POSITION] = Disks.TowerA;
            TowerSet[1][NAME_POSITION] = Disks.TowerB;
            TowerSet[2][NAME_POSITION] = Disks.TowerC;
        }

        public void Show()
        {
            for (int i = 0; i < DIMENTION_1; i++)
            {
                for (int j = 0; j < DIMENTION_2; j++)
                {
                    Console.Write(TowerSet[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void TransferDisks(int height, Disks[] TowerA, Disks[] TowerB, Disks[] TowerC)
        {
            if (height >= 0)
            {
                TransferDisks(height - 1, TowerA, TowerC, TowerB);
                Console.WriteLine("Move disk " + TowerA[height] + " from " + TowerA[NAME_POSITION] + " to " + TowerB[NAME_POSITION]);
                var tmp = TowerA[height];
                TowerA[height] = Disks.Empty;
                TowerB[height] = tmp;
                Show();
                Console.WriteLine();
                TransferDisks(height - 1, TowerC, TowerB, TowerA);
            }
        }

        public enum Disks
        {
            Empty,
            Disk1,
            Disk2,
            Disk3,
            Disk4,
            Disk5,
            TowerA,
            TowerB,
            TowerC
        }

    }
}
