using OpenQA.Selenium;

namespace SeleniumProject.Pages
{
    public class Page
    {
        public IWebDriver Driver { get; protected set; }
        public Page(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
