using TechTalk.SpecFlow;

namespace SeleniumAutomation
{
    [Binding]
    public sealed class StepDefinition
    {

        private SelTest selTest;

    
        [Given("I am on the website")]
        public void GivenIAmOnTheWebsite()
        {
            selTest = new SelTest();
            // _scenarioContext.Pending();
        }

        [Given("I want to log in")]
        public void GivenIWantToLogin()
        {
            selTest.ClickLogin();
            // ScenarioContext.Current.Pending();
        }

        [When("I enter the credentials")]
        public void WhenIEnterTheCredentials()
        {
            selTest.FillCredentials();
            // ScenarioContext.Current.Pending();
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            selTest.ClickSignIn();
            // ScenarioContext.Current.Pending();
        }

        [Then("I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            Console.WriteLine("Logged in");
            // ScenarioContext.Current.Pending();
        }
    }
}