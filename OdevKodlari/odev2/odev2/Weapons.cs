using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    public class Weapons
    {
        public string Name { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Damage { get; set; }
    }

    public class Vandal : Weapons, IAutoFire
    {
        
        public int FireDamage()
        {
            MinDamage = 0;
            MaxDamage = 10;
            Random rnd = new Random();
            Damage = rnd.Next(MinDamage, MaxDamage);
            return Damage;
        }
    }

    public class OperatorAWM : Weapons,IScope,IAutoFire
    {
        public bool ScopeIsThere { get; set; }

        public int FireDamage()
        {
            MinDamage = 0;
            MaxDamage = 10;
            Random rnd = new Random();
            Damage = rnd.Next(MinDamage, MaxDamage);
            return Damage;
        }

        public int ScopeDamage()
        {
            Damage = 100;
            return Damage;
        }
    }

    public class Prowler : Weapons, IBurst
    {
        public int BurstDamage()
        {
            MinDamage = 0;
            MaxDamage = 10;
            Random rnd = new Random();
            Damage = rnd.Next(MinDamage, MaxDamage);
            return Damage * 3;
        }
    }

    public class Knife : Weapons, IKnife
    {
        public bool IsClose { get; set; }
        public int KnifeDamage()
        {
            MinDamage = 0;
            MaxDamage = 5;
            Random rnd = new Random();
            Damage = rnd.Next(MinDamage, MaxDamage);
            return Damage;
        }
    }

}
