using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismProject.Entities
{
    class OutSourcedEmployee : Employee
    {
        public double AdditionalChager { get; set; }

        public OutSourcedEmployee()
        {
        }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalChager)
            : base(name, hours, valuePerHour)
        {
            AdditionalChager = additionalChager;
        }

        public sealed override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalChager;
        }
    }
}
