using DemoLibrary.Entity;
using DemoLibrary.Infra;
using DemoLibrary.Interface;

namespace DemoLibrary.Services
{
    public class TaxCalculatorService
    {
        public TaxPayer CalculateTaxPercentage(TaxPayer taxPayer)
        {
            var ruleType = typeof(ITaxRule);
            IEnumerable<ITaxRule?> rules = this.GetType().Assembly.GetTypes()
                .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
                .Select(r => Activator.CreateInstance(r) as ITaxRule);

            var engine = new TaxRuleEngine(rules);

            return engine.CalculateTaxPercentage(taxPayer);
        }
    }
}

