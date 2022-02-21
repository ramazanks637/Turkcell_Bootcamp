using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    public class Game
    {
        

        void Shotp1(Player player1,Player player2)
        {
            
            player2.Health = player2.Health - player1.Weapon.Damage;
            Console.WriteLine("");
            
        }
        void Shotp2(Player player1, Player player2)
        {
            player1.Health = player1.Health - player2.Weapon.Damage;
        }
    }
}
