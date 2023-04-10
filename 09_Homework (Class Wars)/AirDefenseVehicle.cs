using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Homework__Class_Wars_
{
    class AirDefenseVehicle : CombatVehicle
    {
        public int Range { get; private set; }
        public int FireRate { get; private set; }
        public int Mmobility { get; private set; }

        public AirDefenseVehicle(string model, int health, int range, int fireRate, int mobility)
            : base("Air Defense Vehicle", model, health)
        {
            Range = range;
            FireRate = fireRate;
            Mmobility = mobility;
        }

        public override int Attack()
        {
            return 150 + Range * (FireRate / 10);
        }

        public override void Defense(int damage)
        {
            Health -= damage / Mmobility;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Air Defense Vehicle: {Model}\nHealth: {Health}\nRange: {Range}\nFire Rate: {FireRate}\nMobility: {Mmobility}\n");
        }
    }
}
