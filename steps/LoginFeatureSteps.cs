using BDD_Test_Framework.pages;
using BDD_Test_Framework.utility;
using System;
using TechTalk.SpecFlow;

namespace BDD_Test_Framework.steps
{
    [Binding]
    public class LoginFeatureSteps : reusableMethods
    {
        LoginPage loginPage = new LoginPage();
        [Given(@"the user launch the application")]
        public void GivenTheUserLaunchTheApplication()
        {
            loadRepositories();
            launchApplication(repo.GetString("baseURL"));
        }
        
        [When(@"the user enter valid username password")]
        public void WhenTheUserEnterValidUsernamePassword()
        {
            loginPage.enterUserName("Admin");
            loginPage.enterPassword("admin123");
        }
        
        [When(@"the user click on the login button")]
        public void WhenTheUserClickOnTheLoginButton()
        {
            loginPage.clickLoginButton();
        }
        
        [Then(@"the user should be able to login successfully")]
        public void ThenTheUserShouldBeAbleToLoginSuccessfully()
        {
            System.Threading.Thread.Sleep(10000);
            quitBrowser();
        }
    }
}
