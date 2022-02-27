using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    public class Game
    {

        Player playerOne;
        Player playerTwo;

        public Game()
        {
            playerOne = new Player();
            playerTwo = new Player();
        }

        public void StartGame(){
            GetPlayerName(playerOne);
            GetPlayerName(playerTwo);

            WeaponSelect(playerOne);
            WeaponSelect(playerTwo);

            while (playerOne.Health > 0 && playerTwo.Health > 0)
            {
                playerOne.Attack(playerTwo);
                playerTwo.Attack(playerOne);
            }

            if(playerOne.Health > 0)
                Console.WriteLine("Player 1 won");
            else
                Console.WriteLine("Player 2 won");
        }

        private static void WeaponSelect(Player player)
        {

            Console.WriteLine(player.NickName+" adlı oyuncu Silah seçim Ekranı: ");
            Console.WriteLine(
                "[1] Vandal \n" +
                "[2] OperatorAWM \n" +
                "[3] Prowler \n" +
                "[4] Knife"
                );
            Console.Write("Seçmek istediğiniz silah : ");
            int button = Convert.ToInt32(Console.ReadLine());
            switch (button)
            {
                case 1:
                    player.Weapon = new Vandal();
                    Console.WriteLine("Vandal silahı seçildi");
                    //((Vandal)weapon).FireDamage();
                    break;
                case 2:
                    player.Weapon = new OperatorAWM();
                    Console.WriteLine("Operatör silahı seçildi");
                    break;
                case 3:
                    player.Weapon = new Prowler();
                    Console.WriteLine("Prowler silahı seçildi");
                    break;
                case 4:
                    player.Weapon = new Knife();
                    Console.WriteLine("Bıçak seçildi");
                    break;

                default:
                    Console.WriteLine("Hatalı seçim olduğu için otomatik olarak vandal silahı atandı.");
                    player.Weapon = new Vandal();
                    break;
            }
        }

        private void GetPlayerName(Player player)
        {
            Console.Write("İsim gir:");
            player.NickName = Console.ReadLine();
        }
    }
}
