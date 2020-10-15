using OOPAssignment;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.OOP.Inheritance
{//INHERITANCE: TAKING AN OBJECT THAT ALREADY EXSISTS AND DEFINING ANOTHER BY ITS DIFFERENCES
    class WidgetI : Product
    {
        public string Size { get; set; } = "Medium";
        public string Model { get; set; } = "Basic";
        

        //public WidgetI (string size, string model) : base (Description, Unit, Price)
        //{
        //    this.Size = size;
        //    this.Model = model;
        //}
        public WidgetI() : base ()
        {

        }
    }
}
