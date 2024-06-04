using FluentAssertions.Equivalency;
using System;
using TechTalk.SpecFlow;
using BDD;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TaxCalculationStepDefinitions
    {
        private decimal annualIncome;
        private decimal calculatedTax;


        [Given(@"my annual income is (.*)")]
        public void GivenMyAnnualIncomeIs(int income)
        {
            annualIncome = income;
        }

        [When(@"I calculate the tax")]
        public void WhenICalculateTheTax()
        {
            calculatedTax = TaxCalc.CalculateTax(annualIncome);
        }
        
        [Then(@"the tax amount should be (.*)")]
        public void ThenTheTaxAmountShouldBe(int expectedTax)
        {
            if (calculatedTax != expectedTax)
            {
                throw new Exception($"Expected tax amount: {expectedTax}, but calculated tax amount: {calculatedTax}");
            }
        }
    }
}
