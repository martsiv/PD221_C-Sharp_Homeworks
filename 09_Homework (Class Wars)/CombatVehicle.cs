using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Homework__Class_Wars_
{
    abstract class CombatVehicle
    {
        public string Type { get; private set; }
        public string Model { get; private set; }
        public int Health { get; protected set; }

        public CombatVehicle(string type, string model, int health)
        {
            Type = type;
            Model = model;
            Health = health;
        }

        public abstract int Attack();
        public abstract void Defense(int damage);

        public bool IsDestroyed()
        {
            return Health <= 0;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Type}: {Model}\nHealth: {Health}\n");
        }
    }
}
