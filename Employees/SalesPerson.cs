using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class SalesPerson : Employee
    {
        //Кол-во продаж
        public int SalesNumber { get; set; }

        public SalesPerson() { }

        public override void GiveBonus(float amount)
        {
            int salesBonus = 0;

            if (SalesNumber >= 0 && SalesNumber <= 100)
            {
                salesBonus = 10;
            }
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                {
                    salesBonus = 15;
                }
                else
                {
                    salesBonus = 20;
                }
            }

            base.GiveBonus(amount * salesBonus);
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();

            Console.WriteLine($"Number of Sales: {SalesNumber}");
        }
    }
}
