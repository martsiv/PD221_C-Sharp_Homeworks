using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Homework__Class_Wars_
{
    internal class Army
    {
        public List<CombatVehicle?> CombatVehicles { get; private set; }
        public void AddVehicle(CombatVehicle vehicle)
        {
            CombatVehicles.Add(vehicle);
        }
        public void RemoveVehicle(CombatVehicle vehicle) { CombatVehicles.Remove(vehicle); }
        public CombatVehicle GetRandomVehicle()
        {
            Random rand = new Random();
            int index = rand.Next(CombatVehicles.Count);
            return CombatVehicles[index];
        }
        public void ShowArmyInfo()
        {
            foreach (CombatVehicle vehicle in CombatVehicles)
            {
                vehicle.ShowInfo();
            }
        }
        public bool HasAliveVehicles()
        {
            foreach (CombatVehicle vehicle in CombatVehicles)
            {
                if (!vehicle.IsDestroyed())
                {
                    return true;
                }
            }
            return false;
        }
        public Army()
        {
            CombatVehicles = new List<CombatVehicle>();
        }
    }
}
