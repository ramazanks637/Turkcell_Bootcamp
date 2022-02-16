using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Aşçı yemek yapar
             * 
             */
            Asci boluluBirAsci = new Asci();

            Yemek yemek = new Yemek();

            Corba corba = new Corba();
            corba.Ad = "Tarhana";


            boluluBirAsci.Pisir(yemek);
            boluluBirAsci.Pisir(corba);
            





        }
    }
}
