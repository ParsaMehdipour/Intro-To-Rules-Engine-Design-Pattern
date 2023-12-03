using DemoLibrary.Entity;

namespace DemoLibrary.Interface
{
    public interface ITaxRule
    {
        TaxPayer CalculateTaxPercentage(TaxPayer taxPayer, double currentPercentage);
    }
}
