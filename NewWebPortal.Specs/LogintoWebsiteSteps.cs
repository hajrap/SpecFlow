using System;
using System.Configuration;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework.Internal;

namespace NewWebPortal.Specs
{
    [Binding]
    public class LogintoWebsiteSteps
    {
        IWebDriver driver;

        [Given(@"Navigate to ASG Website")]
        public void GivenNavigateToASGWebsite()
        {
            driver = new ChromeDriver();
            driver.Url = Convert.ToString(ConfigurationManager.AppSettings["ApplicationUrl"]);
        }
        
        [When(@"I enter UserID and Password and click Submit")]
        public void WhenIEnterUserIDAndPasswordAndClickSubmit()
        {
            driver.FindElement(By.Id("UserName")).SendKeys("31034468");
            driver.FindElement(By.Id("Password")).SendKeys("Asg3166!");
            driver.FindElement(By.Id("btnLoginSubmit")).Click();
        }
        
        [Then(@"I see welcome to MyAsg page")]
        public void ThenISeeWelcomeToMyAsgPage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            Assert.That(driver.FindElement(By.PartialLinkText("HOME")).Displayed);
            driver.Quit();  
        }
    }
}
