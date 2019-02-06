using OpenQA.Selenium;

namespace SeleniumProject.Pages
{
    public class HomePage : Page
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        public IWebElement LoginButton
        {
            get
            {
                return Driver.FindElement(By.Id("big_login_button"));
            }
        }

        public IWebElement HomeButton
        {
            get
            {
                return Driver.FindElement(By.Id("bb_home"));
            }
        }

        /// The same as above, just shorthand
        /// 
        public IWebElement SchoolsButton { get => Driver.FindElement(By.Id("bb_schools")); }
    }
}
