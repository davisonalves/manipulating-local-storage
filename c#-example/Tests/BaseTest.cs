using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace c__example;

public abstract class BaseTest
{
    protected WebDriver driver;
    protected string baseUrl = "https://bugbank.netlify.app";

    [OneTimeSetUp]
    public void BeforeAllTests()
    {
        driver = new ChromeDriver();
    }

    [OneTimeTearDown]
    public void AfterAllTests()
    {
        driver.Quit();
    }
}