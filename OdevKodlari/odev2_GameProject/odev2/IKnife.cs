using System;

namespace odev2
{
    public class IKnife : IWeapon
    {
        public string Name { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public bool Condition { get; set; }
        public int FireDamage(bool Condition)
        {

            Random rnd2 = new Random();
            int Damage = 0;
            if(rnd2.Next(0,2) == 0){
                /* Vuracak */
                Random rnd = new Random();
                Damage = rnd.Next(MinDamage, MaxDamage);
            }
            return Damage;
        }
    }
}