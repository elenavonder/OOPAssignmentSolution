using OOPAssignment;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.OOP.Inheritance
{
    class ServiceI : Product
    {
        public int WidgetId { get; set; }
        public int ServiceYears { get; set; } = 1;

        //public ServiceI(int wId, int serviceyears) : base (Description, Unit, Price)
        //{
        //    this.WidgetId = wId;
        //    this.ServiceYears = serviceyears;
        //}

        public ServiceI() : base()
        {

        }
    }
}
