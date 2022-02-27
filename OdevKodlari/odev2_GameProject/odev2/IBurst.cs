using System;

namespace odev2
{
    public class Burst : IWeapon
    {
        public string Name { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Condition { get; set; }
        public int FireDamage(bool Condition)
        {
            Random rnd = new Random();
            int Damage = rnd.Next(MinDamage, MaxDamage);
            return Damage * 3;
        }
    }
}