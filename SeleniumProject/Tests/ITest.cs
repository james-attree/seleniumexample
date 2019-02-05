namespace SeleniumProject.Tests
{
    public interface ITest
    {
        ETestResult Result { get; }
        void SetUp();
        void Run();
        void Shutdown();
    }
}
