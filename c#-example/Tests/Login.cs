using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace c__example;

public class Login : BaseTest
{

    private readonly User user = new() 
    {
        Name = "Fulano",
        Email = "fulano@mailinator.com",
        Password = "123",
        AccountNumber = "671-1",
        Balance = 1000,
        Logged = false
    };

    private readonly Scripts scripts = new();
    

    [SetUp]
    public void Setup()
    {
        driver.Navigate().GoToUrl(baseUrl + "/");
        driver.ExecuteScript(scripts.RegisterUser(user));
    }

    [Test]
    public void LoginWithSuccess()
    {

        driver.FindElement(By.CssSelector("[placeholder=\"Informe seu e-mail\"]"))
            .SendKeys(user.Email);
        
        driver.FindElement(By.CssSelector("[placeholder=\"Informe sua senha\"]"))
            .SendKeys(user.Password);
        
        driver.FindElement(By.CssSelector("[type=\"submit\"]"))
            .Click();
        
        new WebDriverWait(driver, TimeSpan.FromSeconds(1)).Until(d => driver.Url == baseUrl + "/home");
        
        Assert.That(driver.Url, Is.EqualTo(baseUrl + "/home"));
    }
}