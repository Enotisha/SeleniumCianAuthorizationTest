using OpenQA.Selenium;

namespace MyFirstTest.PageObject;

public class UserMenuPageObject
{
    private IWebDriver _webDriver;
    private readonly By userId = By.XPath("//a[@class='_25d45facb5--user-id--K1xX7']");
    
    public UserMenuPageObject(IWebDriver webDriver)
    {
        _webDriver = webDriver;
    }

    public string GetUserId()
    {
        WaitUntil.WaitElement(_webDriver, userId);
        string actualUserId = _webDriver.FindElement(userId).Text;
        return actualUserId;
    }
}