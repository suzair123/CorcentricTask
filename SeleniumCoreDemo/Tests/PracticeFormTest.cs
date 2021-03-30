using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCoreDemo.Pages;

namespace SeleniumCoreDemo.Tests
{
    class PracticeFormTest
    {
        IWebDriver driver = new ChromeDriver();
        PracticeFormPage practiceForm;

        [OneTimeSetUp]
        public void Setup() => driver.Navigate().GoToUrl("https://demoqa.com/");

        [Test]
        public void Case1()
        {
            practiceForm = new PracticeFormPage(driver);
            practiceForm.NavigateToForm();
            practiceForm.FillForm();

            Assert.True(driver.FindElement(By.Id("example-modal-sizes-title-lg")).Displayed);
        }

        [Test]
        public void Case2()
        {
            practiceForm = new PracticeFormPage(driver);
            driver.Navigate().GoToUrl("https://demoqa.com/");
            practiceForm.NavigateToForm();
            practiceForm.ScrollAndSubmit();

            Assert.True(practiceForm.IsAttributePresent(practiceForm.firstNameField, "required"));
            Assert.True(practiceForm.IsAttributePresent(practiceForm.lastNameField, "required"));
            Assert.True(practiceForm.IsAttributePresent(practiceForm.maleRadioBtn, "required"));
            Assert.True(practiceForm.IsAttributePresent(practiceForm.femaleRadioBtn, "required"));
            Assert.True(practiceForm.IsAttributePresent(practiceForm.otherRadioBtn, "required"));
            Assert.True(practiceForm.IsAttributePresent(practiceForm.mobileNumField, "required"));
        }

        [OneTimeTearDown]
        public void TearDown() => driver.Quit();
    }
}
