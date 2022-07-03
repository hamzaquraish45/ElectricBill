using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBill
{
    internal class Residential:Consumer

    {
        public Residential(int units)
        {
            this.units = units;
        }
        public override int calculateBill()
        {
            if (units <= 100)
            {
                return (units * 5);
            }
            else if (units <= 200)
            {
                return (100 * 8) + (units - 100) * 17;
            }
            else if (units <= 500)
            {
                return (100 * 8) + (100 * 21) + (units - 200) * 23;
            }
            else if (units > 500)
            {
                return (100 * 8) + (100 * 21) + (300 * 23) + (units - 500) * 69;
            }
            return 0;
        }

        public override double taxedBill(int bill)
        {
            this.taxBill = bill + (bill * 0.13);

            return this.taxBill;
        }
    }
}
