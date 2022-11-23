using MarsQaProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQaProject.Pages
{
    public class Educationpage
    {
        public void GoToEducationPage(IWebDriver driver)
        {
            
            IWebElement educationLink = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[1]/a[3]"));
            educationLink.Click();
        }

        public void AddEducationSteps(IWebDriver driver,string University,string Degree) 
        {
            IWebElement addNew = driver.FindElement(By.XPath("//thead/tr[1]/th[6]/div[1]"));
            addNew.Click();

            IWebElement universityName = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
            universityName.SendKeys(University);

            IWebElement countryOfUni = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/select[1]"));
            countryOfUni.Click();

            IWebElement selectCountryOfUni = driver.FindElement(By.XPath("//option[contains(text(),'Bangladesh')]"));
            selectCountryOfUni.Click();

            IWebElement title = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/select[1]"));
            title.Click();

            IWebElement selectTitle = driver.FindElement(By.XPath("//option[contains(text(),'B.Sc')]"));
            selectTitle.Click();

            IWebElement degree = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/input[1]"));
            degree.SendKeys(Degree);

            IWebElement yearOfGraduation = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/select[1]"));
            yearOfGraduation.Click();

            IWebElement selectYear = driver.FindElement(By.XPath("//option[contains(text(),'2007')]"));
            selectYear.Click();

            IWebElement clickadd = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/input[1]"));
            clickadd.Click();

            //Explicit Wait
           
            Wait.WaitToExist(driver, "XPath", "//td[contains(text(),'Bangladesh')]",20);


        } 

        public string GetCountry(IWebDriver driver)
        {
            IWebElement getCountryName = driver.FindElement(By.XPath("//tbody/tr/td[1]"));
            return getCountryName.Text;
        }

        public string GetUniversity(IWebDriver driver) 
        {
            IWebElement getUniversityName = driver.FindElement(By.XPath("//tbody/tr/td[2]"));
            return getUniversityName.Text;
        }

        public string GetTitle(IWebDriver driver) 
        {
            IWebElement gettiTleName = driver.FindElement(By.XPath("//tbody/tr/td[3]"));
            return gettiTleName.Text;
        }

        public string GetDegree(IWebDriver driver)
        {
            IWebElement getDegreeName = driver.FindElement(By.XPath("//tbody/tr/td[4]"));
            return getDegreeName.Text;
        }

        public string GetYear(IWebDriver driver)
        {
            IWebElement getGrdYear = driver.FindElement(By.XPath("//tbody/tr/td[5]"));
            return getGrdYear.Text;
        }

        }
    }


