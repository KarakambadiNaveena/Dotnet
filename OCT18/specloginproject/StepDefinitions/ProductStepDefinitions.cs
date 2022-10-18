using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace specloginproject.StepDefinitions
{
   
    [Binding]
    public class ProductStepDefinitions
    {
        login cal = new login();
        string i;
        int j;
        bool ans;
        [Given(@"user gives prodname as ""([^""]*)""")]
        public void GivenUserGivesProdnameAs(string coffee)
        {
            i= coffee;
           // throw new PendingStepException();
        }

        [Given(@"User gives qty as (.*)")]
        public void GivenUserGivesQtyAs(int p0)
        {
            j = p0;
           // throw new PendingStepException();
        }

        [When(@"prodname not null or empty and qty >(.*)")]
        public void WhenProdnameNotNullOrEmptyAndQty(int p0)
        {
            Console.WriteLine($"{nameof(WhenProdnameNotNullOrEmptyAndQty)}");
            //throw new PendingStepException();
        }

        [Then(@"successfully added")]
        public void ThenSuccessfullyAdded()
        {
            ans = cal.Addtocart(i, j);
            Assert.AreEqual(ans, true);
            Console.WriteLine("Successfully added");
            //throw new PendingStepException();
        }
    }
}
