using OpenQA.Selenium;
using SeleniumProject.Pages;

namespace SeleniumProject.Tests.Signup
{
    class HomeButtonTest : Test
    {
        public HomeButtonTest(IWebDriver driver) : base(driver) { }

        public override void Run()
        {
            HomePage homePage = new HomePage(Driver);

            // Check that it has the correct text
            if(homePage.HomeButton.Text == "Home")
            {
                // If so, make this test pass
                Result = ETestResult.Passed;
            }
        }
    }
}
