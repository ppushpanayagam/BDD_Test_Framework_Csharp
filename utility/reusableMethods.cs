using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Reflection;
using System.Resources;

namespace BDD_Test_Framework.utility
{    

    public class reusableMethods
    {
        public static IWebDriver driver;
        public static ResourceManager repo;

        public void launchApplication(String appURL) 
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = appURL;        
        }
        public void loadRepositories()
        {
            repo = new ResourceManager("BDD_Test_Framework.utility.resources.repository", Assembly.GetExecutingAssembly());
        }
        public void enterById(String locator, String data)
        {
            driver.FindElement(By.Id(locator)).SendKeys(data);
        }
        public void clickById(String locator)
        {
            driver.FindElement(By.Id(locator)).Click();
        }
        public void quitBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
