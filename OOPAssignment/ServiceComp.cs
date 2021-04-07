using OOPAssignment;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.OOP.Composition
{
    class Service
    {
        public Product product { get; set; }
        public int WidgetId { get; set; }
        public int ServiceYears { get; set; } = 1;


        public Service()
        {
            this.product = new Product();
        }
    }
}
