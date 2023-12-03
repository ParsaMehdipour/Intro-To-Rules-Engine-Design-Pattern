using DemoLibrary.Entity;
using DemoLibrary.Interface;

namespace DemoLibrary.Infra.TaxRules
{
    public class SingleRule : ITaxRule
    {
        public TaxPayer CalculateTaxPercentage(TaxPayer taxPayer, double currentPercentage)
        {
            if (taxPayer.IsSingle)
                taxPayer.TaxedAmount += ((taxPayer.GrossIncome - 40000) * .1);
            return taxPayer;
        }
    }
}
