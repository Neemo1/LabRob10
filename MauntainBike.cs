using System;
using System.Collections.Generic;
using System.Text;

namespace LabRob10
{
    class MauntainBike : Bike // Наследует значения из класса Байк
    {
        private string chain;
        public MauntainBike(int id, string name, string wheel, string chain) : base(id, name, wheel)
        {
            base.Id = id;
            this.Name = name;

            this.Wheel = wheel;

            this.Chain = chain;
        }

        public string Chain { get => chain; set => chain = value; }
        public override void Print()
        {
            Console.WriteLine("MauntainBike.Print");
            base.Print();
            Console.WriteLine($"Chain = {chain}");
        }
        public override void Clear()
        {
            Console.WriteLine("MauntainBike.Clear");
        }
    }
}
