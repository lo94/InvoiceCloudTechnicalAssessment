using OpenQA.Selenium;

namespace InvoiceCloudTechnicalAssessment.PageObjects
{
	public class AddRemoveElementsPage : BasePage
	{
		public By addElementButton = By.CssSelector("button[onclick='addElement()']");
		public By deleteButton = By.CssSelector("button.added-manually");

		public AddRemoveElementsPage(IWebDriver driver) : base(driver, "add_remove_elements/")
		{

		}

		public AddRemoveElementsPage ClickAddElementButton()
		{
			WaitForElementToExist(addElementButton);
			driver.FindElement(addElementButton).Click();
			return this;
		}

		public AddRemoveElementsPage ClickDeleteElementButton()
		{
			WaitForElementToExist(deleteButton);
			driver.FindElement(deleteButton).Click();
			return this;
		}

		public int AddedElementCount()
		{
			return ElementCount(deleteButton);
		}
	}
}
