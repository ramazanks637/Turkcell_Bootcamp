using System;

namespace LiskovSubstitution
{
    class Program
    {
        public static object Datetime { get; private set; }

        static void Main(string[] args) =>
            /*
*  Bir base class ve bir de bu class'dan miras alan derived class olsun. derived class, base'in davranışını Değiştirmemeli
*  Base -> Derived birbirlerinin yerine kullanılabilir olmalı.

*/

            Console.WriteLine(Datetime.Now.ToShortDateString());


    }
}
