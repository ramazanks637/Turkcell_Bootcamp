using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    public class AutoFire: IWeapon
    {
        public string Name { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public int FireDamage(bool Condition){
            Random rnd = new Random();
            int Damage = rnd.Next(MinDamage, MaxDamage);
            return Damage;
        }
    }
}
