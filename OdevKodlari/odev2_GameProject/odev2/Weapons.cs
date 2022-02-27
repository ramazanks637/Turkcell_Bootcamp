using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{

    public class Vandal:AutoFire
    {
        public Vandal(){
            base.Name = "Vandal";
            base.MinDamage = 0;
            base.MaxDamage = 10;
        }
    }

    public class OperatorAWM : Scope
    {
        public bool ScopeIsThere { get; set; }
        public OperatorAWM()
        {
            base.Name = "OperatorAWM";
            base.MinDamage = 0;
            base.MaxDamage = 100;
        }
    }

    public class Prowler : Burst
    {
        public Prowler()
        {
            base.Name = "Prowler";
            base.MinDamage = 0;
            base.MaxDamage = 5;
        }
    }

    public class Knife : IKnife
    {
        public bool IsClose { get; set; }
        public Knife()
        {
            base.Name = "Knife";
            base.MinDamage = 0;
            base.MaxDamage = 3;
        }
    }

}
