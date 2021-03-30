using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCoreDemo.Pages
{
    public class PracticeFormPage
    {
        private const string FirstName = "Michael";
        private const string LastName = "John";
        private const string MobileNum = "03344532456";
        private Student student;
        public PracticeFormPage(IWebDriver driver)
        {
            Driver = driver;
            student = Student.Create(FirstName,
                                     LastName,
                                     MobileNum);
        }

        private IWebDriver Driver { get; }

        public IWebElement lnkSubmit => Driver.FindElement(By.CssSelector("#submit"));
        public IWebElement lnkForm => Driver.FindElement(By.CssSelector("#app div.card:nth-child(2)"));
        public IWebElement lnkPracticeForm => Driver.FindElement(By.XPath("//span[contains(text(),'Practice Form')]"));

        public IWebElement firstNameField => Driver.FindElement(By.Id("firstName"));
        public IWebElement lastNameField => Driver.FindElement(By.Id("lastName"));

        public IWebElement maleRadioBtn => Driver.FindElement(By.Id("gender-radio-1"));
        public IWebElement femaleRadioBtn => Driver.FindElement(By.Id("gender-radio-2"));
        public IWebElement otherRadioBtn => Driver.FindElement(By.Id("gender-radio-3"));
        public IWebElement mobileNumField => Driver.FindElement(By.Id("userNumber"));

        public void ClickSubmit() => lnkSubmit.Click();
        public void ClickForm() => lnkForm.Click();
        public void ClickPracticeForm() => lnkPracticeForm.Click();

        public void FillForm()
        {
            firstNameField.SendKeys(student.FirstName);
            lastNameField.SendKeys(student.LastName);
            //IWebElement ele = driver.FindElement(By.XPath("//input[@id='gender-radio-1']"));
            var jse = (IJavaScriptExecutor)Driver;
            jse.ExecuteScript("arguments[0].click()", maleRadioBtn);
            mobileNumField.SendKeys(student.MobileNum);
            ScrollAndSubmit();
        }

        public void NavigateToForm()
        {
            ClickForm();
            ClickPracticeForm();
        }

        public void ScrollAndSubmit()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
            ClickSubmit();
        }



        public bool IsAttributePresent(IWebElement element, string attribute)
        {
            bool result = false;
            try
            {
                string value = element.GetAttribute(attribute);
                if (value != null)
                {
                    result = true;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            return result;
        }
    }
}
