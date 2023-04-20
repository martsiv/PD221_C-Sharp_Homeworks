using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Homework__Class_Wars_
{
    class ArmoredCar : CombatVehicle
    {
        public int WeaponCount { get; private set; }
        public int Speed { get; private set; }

        public ArmoredCar(string model, int health, int weaponCount, int speed)
            : base("Armored Car", model, health)
        {
            WeaponCount = weaponCount;
            Speed = speed;
        }

        public override int Attack()
        {
            return 50 * WeaponCount;
        }

        public override void Defense(int damage)
        {
            Health -= (damage - Speed / 2);
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Armored Car: {Model}\nHealth: {Health}\nWeapon Count: {WeaponCount}\nSpeed: {Speed}\n");
        }
    }
}
