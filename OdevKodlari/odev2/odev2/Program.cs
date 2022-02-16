using System;

namespace odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Oyuncu Uygulaması

            •	Her oyuncu Ad, Yaş ve Silah özelliklerine sahiptir. 
            •   Oyuncular silah seçme ekranından silahlarını seçecek.
            •   Her oyuncu Saldırma davranışlarını gerçekleştirebilir.
            •	Her silah; isim,minDamge,maxDamage,damage bilgilerini içermekte olup, 
            •   Silahlar genel olarak çoklu ve tekli olmak üzere ikiye ayrılmıştır. 
            –	çoklu silahlarda; aynı anda birden fazla hasar, 
            –	tekli silahlarda ise tek hasar bulunmaktadır.
            •	Nişan alma davranışı gerçekleşirken, eğer oyuncunun dürbünlü bir silahı varsa,
                hedef kafadan vurulup tekte ölecek, dürbünsüz ise; Normal random hasar alacak.
           
             */

            Player player1 = new Player();
            Player player2 = new Player();
            Weapons weapon = new Weapons();

            GetPlayerName(player1);
            GetPlayerName(player2);
            WeaponSelect(player1,weapon);
            WeaponSelect(player2, weapon);



        }

        private static void WeaponSelect(Player player, Weapons weapon)
        {
            Console.WriteLine("Silah seçim Ekranı: ");
            Console.WriteLine(
                "[1] Vandal \n" +
                "[2] OperatorAWM \n" +
                "[3] Prowler \n" +
                "[4] Knife"
                );
            Console.WriteLine("Seçmek istediğiniz silah : ");
            int button = Convert.ToInt32(Console.ReadLine());
            switch (button)
            {
                case 1:
                    weapon = new Vandal();
                    break;
                case 2:
                    weapon = new OperatorAWM();
                    break;
                case 3:
                    weapon = new Prowler();
                    break;
                case 4:
                    weapon = new Knife();
                    break;

                default:
                    Console.WriteLine("Hatalı seçim olduğu için otomatik olarak vandal silahı atandı.");
                    weapon = new Vandal();
                    break;
            }

            player.Weapon = weapon;

        }

        private static void GetPlayerName(Player player)
        {
            Console.WriteLine("İsim gir:");
            player.NickName = Console.ReadLine();
            
        }




    }
}
