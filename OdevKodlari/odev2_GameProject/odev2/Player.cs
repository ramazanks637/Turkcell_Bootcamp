using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    public class Player
    {
        public string NickName { get; set; }
        public IWeapon Weapon { get; set; }
        public int Health { get; set; } = 100;

        public void Attack(Player playerTo){
            int Damage = 0;
            if(Weapon is Scope)
            {  
                Console.WriteLine(NickName +" isimli oyuncu! Silahının dürbününü açmak ister misin? (E/H)");
                string answer = Console.ReadLine();
                Damage = Weapon.FireDamage(answer == "E" || answer == "e");
            }
            else
            {
                Damage = Weapon.FireDamage(true);
            }
            playerTo.Health -= Damage;
            Console.WriteLine(NickName + " isimli oyuncu " + playerTo.NickName + " isimli oyuncuya " + Damage + " hasar verdi. Kalan canı: " + playerTo.Health);
        }
    }


}
