using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9
{
    class PropertyTaxCalc
    {
        private decimal millageRate = 10.03M;
        private decimal exception = 25000;
        private decimal assessedIncrease = .027M;

        public PropertyTaxCalc(string propertyAddress, decimal lastYearValue, decimal currentYearValue)
        {
            PropertyAddress = propertyAddress;
            LastYearValue = lastYearValue;
            CurrentYearValue = currentYearValue;
        }



        public string PropertyAddress { get; set; }
        public decimal LastYearValue { get; set; }
        public decimal CurrentYearValue { get; set; }

        public decimal Current_Value()
        {
            return (LastYearValue * assessedIncrease) + LastYearValue;

        }
        public decimal Taxable_Value()
        {
            return CurrentYearValue - exception;
        }

        public decimal Taxes_Due()
        {
            return (Taxable_Value() / 1000) * millageRate;
        }


        public override string ToString()
        {
            return "Property Addres: " + PropertyAddress +
                   "\nLast Year Assessd Value: " + LastYearValue.ToString("C") +
                   "\nCurrent Assessed Value: " + Current_Value().ToString("C") +
                   "\nExemption:" + exception.ToString("C") +
                   "\nTaxable Value: " + Taxable_Value().ToString("C") +
                   "\nMillage rate: " + millageRate.ToString("C") +
                   "\nTaxes Due: " + Taxes_Due().ToString("C");


        }
    }

}
