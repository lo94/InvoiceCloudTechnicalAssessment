using InvoiceCloudTechnicalAssessment.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InvoiceCloudTechnicalAssessment.PageObjects
{
	public class BasePage
	{
		public IWebDriver driver;
		public string url;
		public BasePage(IWebDriver driver, string url = "")
		{
			this.driver = driver;
			this.url = Constants.BASE_URL + url;
		}

		public void Navigate()
		{
			driver.Navigate().GoToUrl(url);
		}
		public void WaitForElementToExist(By element, float timeout = 2000)
		{
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeout));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(element));
		}

		public void WaitForElementVisible(By element, float timeout = 2000)
		{
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeout));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
		}

		public void WaitForElementClickable(By element, float timeout = 2000)
		{
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeout));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
		}

		public bool DoesElementExist(By element, float timeout = 2000)
		{
			try
			{
				WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeout));
				wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(element));
				return true;
			}
			catch
			{
				return false;
			}
		}

		public int ElementCount(By element, float timeout = 2000)
		{
			try
			{
				return driver.FindElements(element).Count;
			}
			catch
			{
				return 0;
			}
		}
	}
}
