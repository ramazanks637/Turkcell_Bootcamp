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

            Game game = new Game();
            game.StartGame();

        }     
    }
}
