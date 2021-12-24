using System;
using System.Collections.Generic;
using System.Text;

namespace LabRob10
{
    class Scooter : Product // Наследует Значение из класса Продукти
    {
        private int weight;

        public Scooter(int id, string name, int weight) : base(id, name)
        {
            base.Id = id;
            this.Name = name;


            this.weight = weight;
        }

        public int Wheel { get => weight; set => weight = value; }
        public override void Print()
        {

            Console.WriteLine("Scooter.Print");
            base.Print();
            Console.WriteLine($"Weight = {weight} кг");
        }
        public override void Clear()
        {
            Console.WriteLine("Scooter.Clear");
        }
    }
}
