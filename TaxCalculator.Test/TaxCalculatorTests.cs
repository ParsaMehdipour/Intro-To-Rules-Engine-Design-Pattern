using DemoLibrary.Entity;
using DemoLibrary.Services;
using Xunit;
using static Xunit.Assert;

namespace TaxCalculator.Test;

public class TaxCalculatorTests
{
    private readonly TaxCalculatorService _calculator = new();

    [Fact]
    public void Income_For_Single_TaxPayer()
    {
        //Arrange
        TaxPayer taxPayer = new()
        {
            GrossIncome = 300000,
            IsSingle = true,
            IsResidentOrCitizen = true,
        };

        //Act
        var result = _calculator.CalculateTaxPercentage(taxPayer);

        //Assert
        Equal(78000, result.TaxedAmount);
    }

    [Fact]
    public void Income_For_NotSingle_TaxPayer()
    {
        //Arrange
        TaxPayer taxPayer = new()
        {
            GrossIncome = 300000,
            IsSingle = false,
            IsResidentOrCitizen = true,
        };

        //Act
        var result = _calculator.CalculateTaxPercentage(taxPayer);

        //Assert
        Equal(52000, result.TaxedAmount);
    }
}
