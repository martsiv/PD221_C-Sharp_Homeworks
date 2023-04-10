using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Homework__Class_Wars_
{
    internal class Battle
    {
        private Army army1;
        private Army army2;
        public int rounds { get; private set; }
        public int currentRound { get; private set; }
        private bool IsGameOver
        {
            get
            {
                if (army1.HasAliveVehicles() == false || army2.HasAliveVehicles() == false || currentRound > rounds) return true;
                return false;
            }
        }
        public Battle(int rounds)
        {
            army1 = new Army();
            army2 = new Army();

            GenerateArmy(army1);
            GenerateArmy(army2);

            this.rounds = rounds;
            currentRound = 0;
        }
        private void ShowArmyInfo(Army army)
        {
            foreach (CombatVehicle vehicle in army.CombatVehicles)
            {
                vehicle.ShowInfo();
            }
        }
        public void GenerateArmy(Army army)
        {
            Random rand = new Random();
            int count = rand.Next(5, 11);
            for (int i = 0; i < count; i++)
            {
                int type = rand.Next(3);
                string model = $"BM{i + 1}";
                int health = rand.Next(500, 1001);
                switch (type)
                {
                    case 0:
                        int range = rand.Next(1000, 3001);
                        int fireRate = rand.Next(10, 21);
                        int mobility = rand.Next(2, 6);
                        army.AddVehicle(new AirDefenseVehicle(model, health, range, fireRate, mobility));
                        break;
                    case 1:
                        int weaponCount = rand.Next(1, 4);
                        int speed = rand.Next(50, 101);
                        army.AddVehicle(new ArmoredCar(model, health, weaponCount, speed));
                        break;
                    case 2:
                        int reloadTime = rand.Next(5, 11);
                        int accuracy = rand.Next(50, 101);
                        int armor = rand.Next(100, 201);
                        army.AddVehicle(new Tank(model, health, reloadTime, accuracy, armor));
                        break;
                }
            }
        }
        private bool Round(CombatVehicle bm1, CombatVehicle bm2)
        {
            Console.WriteLine($"{bm1.Type} {bm1.Model} vs {bm2.Type} {bm2.Model}");

            while (!bm1.IsDestroyed() && !bm2.IsDestroyed())
            {
                int bm1Attack = bm1.Attack();
                bm2.Defense(bm1Attack);
                Console.WriteLine($"{bm1.Type} {bm1.Model} attacked {bm2.Type} {bm2.Model} and dealt {bm1Attack} damage. {bm2.Type} {bm2.Model} health: {bm2.Health}");

                if (!bm2.IsDestroyed())
                {
                    int bm2Attack = bm2.Attack();
                    bm1.Defense(bm2Attack);
                    Console.WriteLine($"{bm2.Type} {bm2.Model} attacked {bm1.Type} {bm1.Model} and dealt {bm2Attack} damage. {bm1.Type} {bm1.Model} health: {bm1.Health}");
                }
            }

            return !bm1.IsDestroyed();
        }
        private void PrintWinner()
        {
            if (army1.HasAliveVehicles() == false && army2.HasAliveVehicles() == false)
                Console.WriteLine("Both armies had no combat vehicles left, and a draw was declared!");
            if (army1.HasAliveVehicles() == true && army2.HasAliveVehicles() == true)
                Console.WriteLine("After all rounds are completed, both armies have combat vehicles left. A draw has been declared.!");
            else if (army1.HasAliveVehicles() == true)
                Console.WriteLine("Army1 win!");
            else if (army2.HasAliveVehicles() == true)
                Console.WriteLine("Army2 win!");
        }
        public void StartBattle()
        {
            Console.WriteLine("=== Army 1 ===");
            ShowArmyInfo(army1);
            Console.WriteLine("\n=== Army 2 ===");
            ShowArmyInfo(army2);
            Console.WriteLine("\nPress any key to start the battle...");
            Console.ReadKey();
            Console.Clear();
            bool army1Turn = true;
            while (army1.HasAliveVehicles() && army2.HasAliveVehicles() && currentRound < rounds)
            {
                Console.WriteLine($"=== Round {currentRound++ + 1} ===");
                CombatVehicle bm1 = army1.GetRandomVehicle();
                CombatVehicle bm2 = army2.GetRandomVehicle();
                Console.WriteLine($"[{bm1.Type}] {bm1.Model} VS [{bm2.Type}] {bm2.Model}");
                bool army1Wins = Round(bm1, bm2);
                if (army1Wins)
                    Console.WriteLine($"[{bm1.Type}] {bm1.Model} wins!");
                else
                    Console.WriteLine($"[{bm2.Type}] {bm2.Model} wins!");
                if (bm1.Health <= 0)
                    army1.RemoveVehicle(bm1);
                if (bm2.Health <= 0)
                    army2.RemoveVehicle(bm2);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                army1Turn = !army1Turn;
            }
            PrintWinner();
        }
    }
}
