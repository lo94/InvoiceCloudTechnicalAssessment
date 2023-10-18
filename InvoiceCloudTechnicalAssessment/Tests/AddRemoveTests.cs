using InvoiceCloudTechnicalAssessment.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace InvoiceCloudTechnicalAssessment.Tests
{
	[TestFixture]
    public class AddRemoveTests : BaseTestFixture
    {
        public AddRemoveElementsPage addRemovePage;

        [SetUp]
        public void Setup()
        {
			addRemovePage = new AddRemoveElementsPage(driver);
			addRemovePage.Navigate();
        }

        [Test]
        public void AddElementTest()
        {
			addRemovePage.ClickAddElementButton();
			Assert.That(addRemovePage.AddedElementCount(), Is.EqualTo(1));
		}

		[Test]
		public void AddElementsTest()
		{
			addRemovePage.ClickAddElementButton();
			addRemovePage.ClickAddElementButton();
			addRemovePage.ClickAddElementButton();
			addRemovePage.ClickAddElementButton();
			addRemovePage.ClickAddElementButton();
			Assert.That(addRemovePage.AddedElementCount(), Is.EqualTo(5));
		}

		[Test]
		public void RemoveElementTest()
		{
			addRemovePage.ClickAddElementButton();
			Assert.That(addRemovePage.AddedElementCount(), Is.EqualTo(1));
			addRemovePage.ClickDeleteElementButton();
			Assert.That(addRemovePage.AddedElementCount(), Is.EqualTo(0));
		}

		[Test]
		public void RemoveElementsTest()
		{
			addRemovePage.ClickAddElementButton();
			addRemovePage.ClickAddElementButton();
			addRemovePage.ClickAddElementButton();
			addRemovePage.ClickAddElementButton();
			addRemovePage.ClickAddElementButton();
			Assert.That(addRemovePage.AddedElementCount(), Is.EqualTo(5));
			addRemovePage.ClickDeleteElementButton();
			addRemovePage.ClickDeleteElementButton();
			addRemovePage.ClickDeleteElementButton();
			addRemovePage.ClickDeleteElementButton();
			addRemovePage.ClickDeleteElementButton();
			Assert.That(addRemovePage.AddedElementCount(), Is.EqualTo(0));
		}
    }
}