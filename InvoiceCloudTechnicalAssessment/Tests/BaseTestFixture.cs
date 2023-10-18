using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace InvoiceCloudTechnicalAssessment.Tests
{
	public class BaseTestFixture
	{
		protected IWebDriver driver;

		[SetUp]
		public void Setup()
		{
			//driver = new ChromeDriver();
			new DriverManager().SetUpDriver(new ChromeConfig());
			driver = new ChromeDriver();
		}

		[TearDown]
		public void teardown()
		{
			driver.Quit();
		}
	}
}
