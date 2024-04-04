using System.Data.Common;
using System.Runtime.InteropServices;

namespace SInif1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parrot kush= new Parrot();
            Shark balik= new Shark();
            Eagle qartal=new Eagle();
            Chicken cuce= new Chicken();
            Animal[] animals = {kush, balik, qartal};
            Bird[] birds = { kush, qartal, new Chicken { } };

            //foreach( Animal animal in animals ) {
            //    animal.Eat();
            //}
            foreach (Bird bird in birds)
            {
                bird.Fly();
            }
            //qartal.Eat();
            //qartal.Fly();
            //kush.Fly();
            //kush.Eat();
            //balik.Eat();
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine();
            var tuple = Tuple.Create("kifte bozbash", 70);
            var muple = Tuple.Create("duyu", 38, false);
            var kuple = Tuple.Create("yarpaq dolmasi", 65, true, 5.7);
            Console.WriteLine($"Yemek: {tuple.Item1},  Qiymeti: {tuple.Item2}manat");
            Console.WriteLine($"Yemek: {muple.Item1}, Qiymeti: {muple.Item2}manat, Dadı: {muple.Item3}");
            Console.WriteLine($"Yemek: {kuple.Item1}, Qiymeti: {kuple.Item2}manat, Dadı: {kuple.Item3}, Porsh: {kuple.Item4}");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine();

            CarRecord car1 = new CarRecord()
            {
                marka = "Land Rover",
                model = "Range Rover",
                year = 2023
            };
            CarRecord car2 = car1 with { model = "Defender" };
            Console.WriteLine(car1);
            Console.WriteLine(car2);

        }
        record CarRecord(string marka="AAA", string model="BBB", int year =0);

    }
}
    

