using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Ayakkabi papuc = new Ayakkabi();
            Ayakkabi terlik = new Ayakkabi();
            //Console.WriteLine(papuc.OkuMarkasi());

            papuc.YazMarkasi("nike");
            Console.WriteLine(papuc.OkuMarkasi());

            papuc.Tipi="Ramazan";
            Console.WriteLine();


        }
    }
}
