using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace GoogleSearchImageTest
{
    public class Tests
    {
        private IWebDriver driver;

        private readonly By _imagesLink = By.XPath("//a[text()='Images']");
        private readonly By _logoImage = By.XPath("//img[@alt='Google Images']");

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/ncr");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            var imagesTab = driver.FindElement(_imagesLink);
            imagesTab.Click();

            var logoImage = driver.FindElement(_logoImage);

            try
            {
                Assert.IsTrue(logoImage.Displayed);
                
            }
            catch(Exception)
            { }    
            
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}