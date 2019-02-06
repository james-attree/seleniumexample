using OpenQA.Selenium;

namespace SeleniumProject.Tests
{
    class Test : ITest
    {
        public IWebDriver Driver { get; protected set; }
        public ETestResult Result { get; protected set; }

        public Test(IWebDriver driver)
        {
            Driver = driver;
            Result = ETestResult.Failed;
        }

        public virtual void SetUp()
        {
            Driver.Url = "https://widgitonline.com";
        }

        public virtual void Run() { }

        public virtual void Shutdown() { }
    }
}
