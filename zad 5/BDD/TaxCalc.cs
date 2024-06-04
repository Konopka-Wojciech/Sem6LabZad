using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD
{
    public class TaxCalc
    {
        public static decimal CalculateTax(decimal income)
        {
            const decimal FirstThreshold = 120000m;
            const decimal FirstRate = 0.17m;
            const decimal SecondRate = 0.32m;

            if (income <= FirstThreshold)
            {
                return income * FirstRate;
            }
            else
            {
                decimal taxForFirstThreshold = FirstThreshold * FirstRate;
                decimal taxForExcess = (income - FirstThreshold) * SecondRate;
                return taxForFirstThreshold + taxForExcess;
            }
        }
    }
}
