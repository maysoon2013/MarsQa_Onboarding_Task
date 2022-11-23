
using MarsQaProject.Drivers;
using MarsQaProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQaProject.Input;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MarsQaProject.Pages
{
    public class LoginPage
    {
        public static string url = "http://localhost:5000";


        public void loginPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            

            //click on Sign In link
            IWebElement signInLink = driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
            signInLink.Click();

            // Identify User name textfield and enter valid username
            IWebElement userName = driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
            userName.SendKeys(LogInCredential.username);

            //identify Password textfield and enter valid password
            IWebElement password = driver.FindElement(By.XPath("//INPUT[@type='password']"));
            password.SendKeys(LogInCredential.password);

            // Identify Loin button and click on it
            IWebElement login = driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
            login.Click();

            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span", 10);




        }
    }
}
