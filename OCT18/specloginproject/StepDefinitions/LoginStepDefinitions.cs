using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace specloginproject.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        login cal = new login();
        string i, j;
        bool ans;
        [Given(@"User gives userid as '([^']*)'")]
        public void GivenUserGivesUseridAs(string p0)
        {
            i = p0;
        }

        [Given(@"User gives password as '([^']*)'")]
        public void GivenUserGivesPasswordAs(string p0)
        {
            j = p0;
        }

        [When(@"UserClicksLogin")]
        public void WhenUserClicksLogin()
        {
            Console.WriteLine($"{nameof(WhenUserClicksLogin)}");
            // throw new PendingStepException();

        }

        [Then(@"SuccessfulLogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            ans = cal.Login(i, j);
            //Console.WriteLine($"nameof{(ThenSuccessfulLogINMessageShouldDisplay)}");
            Assert.AreEqual(ans, true);
            Console.WriteLine("Successfully");
            // throw new PendingStepException();
        }
    }
}

