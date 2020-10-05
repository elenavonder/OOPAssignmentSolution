using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment
{
    class Product
    {
        //public int NextId = 1;
        public int Id { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; } = "Each";
        public double Price { get; set; }


        //public Product(int id, string Desc, string unit, double price)
        //{
        //    this.Id = id;
        //    this.Description = Desc;
        //    this.Unit = unit;
        //    this.Price = price;
        //}

        public Product()
        {

        }
    }
}
