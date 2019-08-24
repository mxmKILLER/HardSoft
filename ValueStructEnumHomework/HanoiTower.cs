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
            TowerSet[0][DIMENTION_2 - 1] = Disks.TowerA;
            TowerSet[1][DIMENTION_2 - 1] = Disks.TowerB;
            TowerSet[2][DIMENTION_2 - 1] = Disks.TowerC;
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

        public void TransferDisks(int n, Disks[] TowerA, Disks[] TowerB, Disks[] TowerC)
        {
            if (n >= 0)
            {
                TransferDisks(n - 1, TowerA, TowerC, TowerB);
                Console.WriteLine("Move disk " + TowerA[n] + " from " + TowerA[NAME_POSITION] + " to " + TowerB[NAME_POSITION]);
                var tmp = TowerA[n];
                TowerA[n] = Disks.Empty;
                TowerB[n] = tmp;
                TransferDisks(n - 1, TowerC, TowerB, TowerA);
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
