using System;
using System.Collections.Generic;
using System.Text;

namespace Course2.Entites
{
    class OutsourcedEmployee : Employee
    {
        public double AdittionalCharge { get; set; }

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour,double adittionalCharge) : base(name,hours,valuePerHour)
        {
            AdittionalCharge = adittionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdittionalCharge;

        }
    }
}
