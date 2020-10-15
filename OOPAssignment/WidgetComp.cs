using OOPAssignment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CSharp.OOP.Composition
{//COMPOSITION: SIMILAR TO INHERITANCE BUT MAKING AN INSTANCE OF ONE OBJECT INTO ANOTHER
    class Widget
    {
        public Product product { get; set; } //this is null here
        public int Id
        {
            get { return product.Id; }
            set { product.Id = value; }
        }
        public string Size { get; set; } = "Medium";
        public string Model { get; set; } = "Basic";

        public Widget() 
        {
            this.product = new Product();
        }
    }
}
