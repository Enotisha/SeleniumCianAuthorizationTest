using OpenQA.Selenium;

namespace MyFirstTest.PageObject;

public class AuthorizationPageObject
{
    private IWebDriver _webDriver;
    private readonly By otherWayButton = By.XPath("//span[text()='Другим способом']");
    private readonly By loginInputButton = By.XPath("//input[@name='username']");
    private readonly By continueButton = By.XPath("//button[@data-name='ContinueAuthBtn']");
    private readonly By passInputButton = By.XPath("//input[@name='password']");
    private readonly By authContinueButton = By.XPath("//button[@data-name='ContinueAuthBtn']");

    public AuthorizationPageObject(IWebDriver webDriver)
    {
        _webDriver = webDriver;
    }

    public MainMenuPageObject Login (string login, string password)
    {
        WaitUntil.WaitElement(_webDriver, otherWayButton);
        _webDriver.FindElement(otherWayButton).Click();
        WaitUntil.WaitElement(_webDriver, loginInputButton);
        _webDriver.FindElement(loginInputButton).SendKeys(login);
        WaitUntil.WaitElement(_webDriver, continueButton);
        _webDriver.FindElement(continueButton).Click();
        WaitUntil.WaitElement(_webDriver, passInputButton);
        _webDriver.FindElement(passInputButton).SendKeys(password);
        WaitUntil.WaitElement(_webDriver, authContinueButton);
        _webDriver.FindElement(authContinueButton).Click();
        return new MainMenuPageObject(_webDriver);
    }
}