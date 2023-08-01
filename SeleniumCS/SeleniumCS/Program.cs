using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("https://www.youtube.com");
driver.Manage().Window.Maximize();
IWebElement searchText = driver.FindElement(By.Name("search_query"));
searchText.SendKeys("Bert");
IWebElement btnSearch = driver.FindElement(By.Id("search-icon-legacy"));
btnSearch.Click();
Thread.Sleep(5000);
driver.Close();