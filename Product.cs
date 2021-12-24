using System;
using System.Collections.Generic;
using System.Text;

namespace LabRob10
{
    class Product : Guarantee

    {
        private int guarantee = 3;
        private int id;
        private string name;

        public Product()
        {
            id = 0;
            name = "Название товара";

        }
        public Product(int id, string name)
        {
            this.id = id;
            this.name = name;

        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public virtual void Print()
        {
            Console.WriteLine("Product.Print");
            Console.WriteLine("Значение полей");
            Console.WriteLine($"Id = {id}");
            Console.WriteLine($"Name = {name}");

        }
        public virtual void Clear()
        {
            Console.WriteLine("Product.Clear");
        }

        public override int GetGuarantee()
        {
            return guarantee;

        }

        public override void SetGuarantee(int guarantee)
        {
            this.guarantee = guarantee;
        }
    }
}
