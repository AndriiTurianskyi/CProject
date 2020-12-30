using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace CProject
{
    [TestFixture]
    public class SeleniumTest
    {  
            IWebDriver driver;
        [SetUp]
        public void beforeTest()
            {
                driver = new ChromeDriver("D:\\drivers\\chromedriver");
                driver.Url = "https://www.seleniumeasy.com/";
                driver.Manage().Window.Maximize();
            }

            [TearDown]
            public void afterTest()
            {
                driver.Quit();
            }

            [Test]
            public void test1()
            {
                IWebElement searchField = driver.FindElement(By.Id("edit-search-block-form--2"));
                searchField.SendKeys("selenium");
                searchField.SendKeys(Keys.Enter);
                Assert.IsTrue(driver.FindElement(By.CssSelector(" div > section > h2")).Displayed);

            }
        [Test]
        public void test2()
        {
            IWebElement dropdownMore = driver.FindElement(By.CssSelector("li.last.expanded.active.dropdown"));
            dropdownMore.Click();
            IList<IWebElement> moreList = dropdownMore.FindElements(By.ClassName("leaf"));
            Assert.AreEqual("JMeter Tutorials", moreList[1].Text);
        }

        }
    
}
