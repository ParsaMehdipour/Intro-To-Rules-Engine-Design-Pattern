using DemoLibrary.Entity;
using DemoLibrary.Interface;

namespace DemoLibrary.Infra
{
    public class TaxRuleEngine
    {
        private readonly List<ITaxRule> _rules = new();

        public TaxRuleEngine(IEnumerable<ITaxRule?> rules)
        {
            _rules.AddRange(rules);
        }

        public TaxPayer CalculateTaxPercentage(TaxPayer taxPayer)
        {
            foreach (var rule in _rules)
            {
                taxPayer.TaxedAmount += rule.CalculateTaxPercentage(taxPayer, taxPayer.TaxedAmount).TaxedAmount;
            }
            return taxPayer;
        }
    }
}
