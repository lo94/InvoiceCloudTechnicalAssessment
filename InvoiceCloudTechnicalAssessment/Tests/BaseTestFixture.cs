using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace InvoiceCloudTechnicalAssessment.Tests
{
	public class BaseTestFixture
	{
		protected IWebDriver driver;

		[SetUp]
		public void Setup()
		{
			ChromeOptions options = new ChromeOptions();
			options.AddArguments("start-maximized");
			options.AddArguments("--disable-gpu");
			options.AddArguments("--headless");
			//driver = new ChromeDriver();
			new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
			driver = new ChromeDriver(options);
		}

		[TearDown]
		public void teardown()
		{
			driver.Quit();
		}
	}
}
