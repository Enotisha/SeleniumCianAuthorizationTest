using OpenQA.Selenium;

namespace MyFirstTest.PageObject;

public class MainMenuPageObject
{
    private IWebDriver _webDriver;
    private readonly By signInButton = By.XPath("//span[text()='Войти']");
    private readonly By avatarButton = By.XPath("//a[@data-name='UserAvatar']");

    public MainMenuPageObject(IWebDriver webDriver)
    {
        _webDriver = webDriver;
    }

    public AuthorizationPageObject SignIn()
    {
        _webDriver.FindElement(signInButton).Click();
        return new AuthorizationPageObject(_webDriver);
    }

    public UserMenuPageObject UserMenu()
    {
        WaitUntil.WaitElement(_webDriver, avatarButton);
        _webDriver.FindElement(avatarButton).Click();
        return new UserMenuPageObject(_webDriver);
    }
}