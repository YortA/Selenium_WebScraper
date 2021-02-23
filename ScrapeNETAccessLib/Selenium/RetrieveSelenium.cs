using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Timers;		// Timer timer (look up)

// Selenium includes
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace ScrapeNETAccessLib.Selenium
{
	public class RetrieveSelenium
	{
		public static void TestScrape()
		{
			IWebDriver driver = new ChromeDriver("C:\\PROJECTS\\VS Projects\\ScrapeNETWebApp\\ChromeDriver\\chromedriver_win32");
			driver.Url = "https://www.bestbuy.com/";

			// Needs to be after we're on the URL so we can check for elements
			IWebElement element = null;     // used to check for specific elements (such as popups)
			element = driver.FindElement(By.CssSelector(".widgets-view-email-modal .c-modal-grid .c-close-icon"));
			// We found a common pop-up
			if (ElementExists(ref element))
			{
				element.Click();
			}

			// We need to explicitly wait for our pages to load
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.(By.ClassName("search-input")));
			
			//Thread.Sleep(1000);
			driver.FindElement(By.ClassName("search-input")).SendKeys("samsung tablet");
			driver.FindElement(By.CssSelector(".shop-header .appContainer .search-bar .header-search-button")).Click();
			
			


		}

		private static bool ElementExists(ref IWebElement element)
		{
			return element.Displayed;
		}

	}
}
