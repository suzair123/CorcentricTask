using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCoreDemo

{
    //public class Tests
    //{
    //    [SetUp]
    //    public void Setup()
    //    {


    //    }

    //    [Test]
    //    public void Test1()
    //    {
    //        IWebDriver driver = new ChromeDriver();
    //        driver.Navigate().GoToUrl("https://demoqa.com/");
    //        driver.FindElement(By.CssSelector("#app div.card:nth-child(2)")).Click();
    //        driver.FindElement(By.XPath("//span[contains(text(),'Practice Form')]")).Click();
    //        ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
    //        driver.FindElement(By.CssSelector("#submit")).Click();

    //        Assert.True(isAttributePresent(driver.FindElement(By.Id("firstName")), "required"));
    //        Assert.True(isAttributePresent(driver.FindElement(By.Id("lastName")), "required"));
    //        Assert.True(isAttributePresent(driver.FindElement(By.Id("gender-radio-1")), "required"));
    //        Assert.True(isAttributePresent(driver.FindElement(By.Id("gender-radio-2")), "required"));
    //        Assert.True(isAttributePresent(driver.FindElement(By.Id("gender-radio-3")), "required"));
    //        Assert.True(isAttributePresent(driver.FindElement(By.Id("userNumber")), "required"));
    //    }

    //    public bool isAttributePresent(IWebElement element, string attribute)
    //    {
    //        bool result = false;
    //        try
    //        {
    //            string value = element.GetAttribute(attribute);
    //            if (value != null)
    //            {
    //                result = true;
    //            }
    //        }
    //        catch(Exception ex) { }
    //        return result;
    //    }
    //}
}