using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TechnicalTask
{
    class Tests : WebDriver
    {
        private string URL = "https://nordlayer.com/";

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(URL);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void Test()
        {
            IWebElement downloads_btn = Driver.FindElement(By.ClassName("jss1199"));
            downloads_btn.Click();
            
            IWebElement android_btn = Driver.FindElement(By.CssSelector("#device-block > div.nord-row.row.no-gutters > div.nord-col.md\:col-4.hidden.md\:block > div > div:nth-child(2) > div > div > p"));
            android_btn.Click();
            IWebElement android_title = Driver.FindElement(By.CssSelector("#device-block > div.nord-row.row.no-gutters > div.nord-col.md\:col-8 > div.ExpandableBlock.shadow-1.rounded.shadow-none.mb-5.md\:mb-0.ExpandableBlock--open > div.ExpandableBlock__ContentWrap.px-4.pl-0.pr-0.-mb-4 > div > div > h2"));
            Assert.AreEqual("Download NordLayer for Android", android_title.Text);

            IWebElement ios_btn = Driver.FindElement(By.CssSelector("#device-block > div.nord-row.row.no-gutters > div.nord-col.md\:col-4.hidden.md\:block > div > div:nth-child(3) > div > div > p"));
            ios_btn.Click();
            IWebElement ios_title = Driver.FindElement(By.CssSelector("#device-block > div.nord-row.row.no-gutters > div.nord-col.md\:col-8 > div.ExpandableBlock.shadow-1.rounded.shadow-none.mb-5.md\:mb-0.ExpandableBlock--open > div.ExpandableBlock__ContentWrap.px-4.pl-0.pr-0.-mb-4 > div > div > h2"));
            Assert.AreEqual("Download NordLayer for iOS", ios_title.Text);

            IWebElement windows_btn = Driver.FindElement(By.CssSelector("#device-block > div.nord-row.row.no-gutters > div.nord-col.md\:col-4.hidden.md\:block > div > div:nth-child(4) > div > div > p"));
            windows_btn.Click();
            IWebElement windows_title = Driver.FindElement(By.CssSelector("#device-block > div.nord-row.row.no-gutters > div.nord-col.md\:col-8 > div.ExpandableBlock.shadow-1.rounded.shadow-none.mb-5.md\:mb-0.ExpandableBlock--open > div.ExpandableBlock__ContentWrap.px-4.pl-0.pr-0.-mb-4 > div > div > h2"));
            Assert.AreEqual("Download NordLayer for Windows", windows_title.Text);

            IWebElement mac_btn = Driver.FindElement(By.CssSelector("#device-block > div.nord-row.row.no-gutters > div.nord-col.md\:col-4.hidden.md\:block > div > div:nth-child(5) > div > div > p"));
            mac_btn.Click();
            IWebElement mac_title = Driver.FindElement(By.CssSelector("#device-block > div.nord-row.row.no-gutters > div.nord-col.md\:col-8 > div.ExpandableBlock.shadow-1.rounded.shadow-none.mb-5.md\:mb-0.ExpandableBlock--open > div.ExpandableBlock__ContentWrap.px-4.pl-0.pr-0.-mb-4 > div > div > h2"));
            Assert.AreEqual("Download NordLayer for macOS", mac_title.Text);

            IWebElement linux_btn = Driver.FindElement(By.CssSelector("#device-block > div.nord-row.row.no-gutters > div.nord-col.md\:col-4.hidden.md\:block > div > div:nth-child(6) > div > div > p"));
            linux_btn.Click();
            IWebElement linux_title = Driver.FindElement(By.CssSelector("#device-block > div.nord-row.row.no-gutters > div.nord-col.md\:col-8 > div.ExpandableBlock.shadow-1.rounded.shadow-none.mb-5.md\:mb-0.ExpandableBlock--open > div.ExpandableBlock__ContentWrap.px-4.pl-0.pr-0.-mb-4 > div > div > h2"));
            Assert.AreEqual("Download NordLayer for Linux", linux_title.Text);
        }

        [TearDown]
        public void Close()
        {
            Driver.Close();
        }
    }
}