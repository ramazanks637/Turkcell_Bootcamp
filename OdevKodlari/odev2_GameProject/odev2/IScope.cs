using System;

namespace odev2
{
    public class Scope: IWeapon
    {
        public string Name { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        /* public bool Condition { get; set; } */

        public int FireDamage(bool Condition) {
            if(Condition) return 100;
            Random rnd = new Random();
            int Damage = rnd.Next(MinDamage, MaxDamage);
            Condition = false;
            return Damage;
        }
    }
}