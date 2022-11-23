using MarsQaProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQaProject.Pages
{
    public class CertificationPage
    {
        public void GoToCertificationPage(IWebDriver driver)
        {
            IWebElement clickcertification = driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]"));
            clickcertification.Click();

        }
        public void AddCertificateSteps(IWebDriver driver, string Certificate,string CertifiedFrom)
        {
            //wait.WaitForElement(driver, "XPath", "//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]",20);
            IWebElement clickAddNew = driver.FindElement(By.XPath("//thead/tr[1]/th[4]/div[1]"));
            clickAddNew.Click();

            IWebElement certificateName = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
            certificateName.SendKeys(Certificate);

            IWebElement instituteName = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/input[1]"));
            instituteName.SendKeys(CertifiedFrom);

            IWebElement completionYear = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/select[1]"));
            completionYear.Click();

            IWebElement selectComYear = driver.FindElement(By.XPath("//option[contains(text(),'2022')]"));
            selectComYear.Click();

            IWebElement clickOnAddBtn = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
            clickOnAddBtn.Click();
            
            //Implicit Wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

        }

        public string GetCertificate(IWebDriver driver)
        {
            IWebElement getCertificateName = driver.FindElement(By.XPath("//tbody/tr/td[1]"));
            return getCertificateName.Text;
        }

        public string GetCertificateFrom(IWebDriver driver)
        {
            IWebElement getInstituteName = driver.FindElement(By.XPath("//tbody/tr/td[2]"));
            return getInstituteName.Text;
        }

        public string GetCompletionYear(IWebDriver driver)
        {
            IWebElement getComYear = driver.FindElement(By.XPath("//tbody/tr/td[3]"));
            return getComYear.Text;
        }

    }
}
