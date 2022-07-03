using System;

namespace ElectricBill
{
    internal class Program:Consumer
    {
        static void Main(string[] args)
        {
            int units,bill;
            double taxBill;
            string consumerType;

            Console.WriteLine("Enter Consumer Type: ");
            consumerType = Console.ReadLine(); ;
            
            Console.Write("Enter Units: ");
            units = Convert.ToInt32(Console.ReadLine());



            if (consumerType == "commercial")
            {
                Commercial com = new Commercial(units);
                bill = com.calculateBill();
                taxBill = com.taxedBill(bill);
                Console.WriteLine("Electricity bill for " + consumerType + " is: " + taxBill + " Rs.");




            }
            else if (consumerType == "residential")
            {
                Residential com = new Residential(units);
                bill = com.calculateBill();
                taxBill = com.taxedBill(bill);
                Console.WriteLine("Electricity bill for " + consumerType + " is: " + taxBill + " Rs.");
            }

        }
    }
}
