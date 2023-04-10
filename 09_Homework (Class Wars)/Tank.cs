using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Homework__Class_Wars_
{
    class Tank : CombatVehicle
    {
        public int ReloadTime { get; private set; }
        public int Accuracy { get; private set; }
        public int Armor { get; private set; }

        public Tank(string model, int health, int reloadTime, int accuracy, int armor)
            : base("Tank", model, health)
        {
            ReloadTime = reloadTime;
            Accuracy = accuracy;
            Armor = armor;
        }

        public override int Attack()
        {
            return 100 * Accuracy / ReloadTime;
        }

        public override void Defense(int damage)
        {
            Health -= (damage - Armor);
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Tank: {Model}\nHealth: {Health}\nReload Time: {ReloadTime}\nAccuracy: {Accuracy}\nArmor: {Armor}\n");
        }
    }
}
