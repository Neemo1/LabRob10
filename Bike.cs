using System;
using System.Collections.Generic;
using System.Text;

namespace LabRob10
{
    
        class CPrice
        {
            public CPrice() { }
            public void ThePriceIs(bool Is)
            {
                if (Is)
                {
                    Console.WriteLine("Цена есть ...");
                }
                else
                {
                    Console.WriteLine("Цены нет ...");
                }
            }
        }

        class Bike : Product, ITransport//Наследует значения с класса Продукти
        {
            public void Run() { Console.WriteLine(" Транспорт едет"); }
            public void Stop() { Console.WriteLine(" Транспорт стоит"); }
            private string wheel;
            private CPrice Price;

            public Bike(int id, string name, string wheel) : base(id, name)
            {
                base.Id = id;
                this.Name = name;
                this.wheel = wheel;
                Price = new CPrice();

            }
            public void ControlPrice(bool State)
            {
                Price.ThePriceIs(State);
            }
            public string Wheel { get => wheel; set => wheel = value; }

            public override void Print()
            {
                Console.WriteLine("Bike.Print");
                base.Print();
                Console.WriteLine($"Wheel = {wheel}");
            }
            public override void Clear()
            {
                Console.WriteLine("Bike.Clear");
            }


        }


}
