using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Homework__Generic_collections_
{
    internal class HanoiTower
    {
        private int level;
        private Stack<int>[] towers;

        public HanoiTower(int level = 4)
        {
            this.level = 4 < level ? level : 4;
            towers = new Stack<int>[3]
            {
                new Stack<int>(level),
                new Stack<int>(level),
                new Stack<int>(level),
            };
            for (int i = this.level; 0 < i; i--)
                towers[0].Push(i);
        }
        public void Show()
        {
            Console.Clear();
            int tmp = 0;
            //Tower 1
            foreach (var item in towers[0])
            {
                Console.SetCursorPosition(0, level - towers[0].Count + tmp);
                for (int j = 0; j < item; j++)
                    Console.Write("=");
                tmp++;
            }
            //Tower 2
            tmp = 0;
            foreach (var item in towers[1])
            {
                Console.SetCursorPosition(level + 2, level - towers[1].Count + tmp);
                for (int j = 0; j < item; j++)
                    Console.Write("=");
                tmp++;
            }
            //Tower 3
            tmp = 0;
            foreach (var item in towers[2])
            {
                Console.SetCursorPosition((level + 2) * 2, level - towers[2].Count + tmp);
                for (int j = 0; j < item; j++)
                    Console.Write("=");
                tmp++;
            }
        }

        public bool Move(int fromTower, int toTower)
        {
            --fromTower;
            --toTower;
            if (fromTower < 0 || 2 < fromTower || toTower < 0 || 2 < toTower)
                return false;

            if ((level - 1) < towers[toTower].Count || towers[fromTower].Count < 0)
                return false;
            towers[toTower].Push(towers[fromTower].Pop());
            return true;
        }
        private void SolutionHanoi(int lvl, int t1, int t2, int t3)
        {
            if (0 < lvl)
            {
                SolutionHanoi(lvl - 1, t1, t3, t2);
                Move(t1, t2);
                Show();
                Console.ReadKey();
                SolutionHanoi(lvl - 1, t3, t2, t1);
            }
        }
        public void Play()
        {
            SolutionHanoi(level, 1, 2, 3);
        }
    }
}
