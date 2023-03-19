using System.Runtime.CompilerServices;
using MyFirstTest.PageObject;
using OpenQA.Selenium;

namespace MyFirstTest;

public class Tests
{
    private IWebDriver _webDriver;

    [SetUp]
    public void Setup()
    {
        _webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();
        _webDriver.Navigate().GoToUrl("https://cian.ru");
        WaitUntil.ShouldLocate(_webDriver,"https://ekb.cian.ru");
        _webDriver.Manage().Window.Maximize();
    }

    [Test]
    public void Test1()
    {
        var mainMenu = new MainMenuPageObject(_webDriver);
        UserDataForCian.GetUserDataForCian(out var login, out var pass, out var expectedUserId);
        WaitUntil.WaitSomeInterval(1);
        mainMenu.SignIn()
        .Login(login, pass);
        WaitUntil.WaitSomeInterval(1);
        var actualUserId = mainMenu.UserMenu()
        .GetUserId();
        WaitUntil.WaitSomeInterval(1);
        Assert.AreEqual(expectedUserId, actualUserId, "Логин неверный или Вход неудачный");
    }

    [TearDown]
    public void TearDown()
    {
        _webDriver.Quit();
    }
}