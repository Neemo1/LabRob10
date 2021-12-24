using System;

namespace LabRob10
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(0, "Продукт");
            Console.WriteLine("Класс Product");
            p1.Print();
            p1.Clear();
            p1.GetGuarantee();
            p1.MaxGuarantee();
            Console.WriteLine("--------------");
            Console.WriteLine("Класс Bike");
            Bike b1 = new Bike(4, "Велосипед", "Не очень большой");
            b1.Stop();
            b1.Run();
            p1 = new Bike(1, "Велосипед", "Не очень большой");
            p1.Print();
            b1.ControlPrice(false);
            p1.Clear();
            Console.WriteLine("--------------");
            Console.WriteLine("Класс MaintainBike");
            p1 = new MauntainBike(2, "Велосипед", "Не очень большой", "Многоступенчистая цепь");
            p1.Print();
            p1.Clear();
            Console.WriteLine("--------------");
            Console.WriteLine("Класс Scooter");
            p1 = new Scooter(3, "Велосипед", 15);
            p1.Print();
            p1.Clear();
            Console.WriteLine("--------------");
        }
    }
}
