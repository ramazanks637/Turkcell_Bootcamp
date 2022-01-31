using System;

namespace ClassVSObject
{
    class Program
    {
        static void Main(string[] args)
        {

            int yas = 42;
            bool olurMu = true;
            if (yas == 42)
            {

            }

            Person worker = new Person();
            worker.Name = "Murat";
            worker.Age = 38;
            worker.LastName = "köse";

            Person cooker = worker;
            cooker.Name = "Filiz";
            cooker.Age = 24;

            Console.WriteLine(worker.Name);





        }
    }
}
