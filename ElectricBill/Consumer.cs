using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBill
{
    internal class Consumer
    {
        protected int units;
        protected int bill;
        protected double taxBill;
        public Consumer()
        {
            this.units = 0;
            this.bill = 0;
        }
        public Consumer(int unit)
        {
            this.units = unit;
        }

        public virtual int calculateBill()
        {

            return this.bill;
        }
        public virtual double taxedBill(int bill)
        {
            return this.taxBill;
        }
        public void setUnits(int unit)
        {
            this.units = unit;
        }
        public int getUnits()
        {
            return units;
        }

    }
}