using DemoLibrary.Entity;
using DemoLibrary.Interface;

namespace DemoLibrary.Infra.TaxRules
{
    public class IncomeRule : ITaxRule
    {
        public TaxPayer CalculateTaxPercentage(TaxPayer taxPayer, double currentPercentage)
        {
            if (taxPayer.GrossIncome < 40000) taxPayer.TaxedAmount = 0;
            else
            {
                taxPayer.TaxedAmount += ((taxPayer.GrossIncome - 40000) * .1);
            }
            return taxPayer;
        }
    }
}
