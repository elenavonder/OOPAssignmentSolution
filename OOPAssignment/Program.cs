using CSharp.OOP.Composition;
using CSharp.OOP.Inheritance;
using System;

namespace OOPAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var widget = new CSharp.OOP.Composition.Widget();
            widget.Id = 1;

            var Products = new Product[]
            {
                new WidgetI() {Description = "small basic widget", Price = 50, Model = "Basic", Size = "Small"},
                new WidgetI() {Description = "Med, adv widget", Price = 200, Model = "Advanced", Size = "Medium" },
                new WidgetI() {Description = "Large, basic widget", Price = 400, Model = "Basic", }
                new ServiceI() {Description = "Service on widget id 1", Price = 100, WidgetId = 1, ServiceYears = 1 },
                new ServiceI() {Description = "service on widget id 2", Price = 200, WidgetId = 2, ServiceYears = 1 },
                new ServiceI() {Description = "Service on Widget id 3", Price = 300, WidgetId = 3, ServiceYears = 2},

            };
        }
    }
}
