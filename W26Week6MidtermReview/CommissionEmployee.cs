using System;
using System.Collections.Generic;
using System.Text;

namespace W26Week6MidtermReview
{
    public class CommissionEmployee : Employee
    {
        public double GrossSales { get; set; }
        public double CommissionRate { get; set; }

        public CommissionEmployee(string name, double grossSales, double commissionRate) : base(name)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }

        public override double GrossEarnings()
        {
            return GrossSales * CommissionRate;
        }
    }
}
