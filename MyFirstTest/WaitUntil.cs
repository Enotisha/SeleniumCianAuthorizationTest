using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MyFirstTest;

public static class WaitUntil
{
    
    public static void ShouldLocate(IWebDriver webDriver, string location)
    {
   var defaultTimeoutSec = 10;
   try
   {
       new WebDriverWait(webDriver, TimeSpan.FromSeconds(defaultTimeoutSec)).Until(
           ExpectedConditions.UrlContains(location));
   }
   catch (WebDriverTimeoutException ex)
   {
       throw new NotFoundException($"Cannot find out that app in spicific location: {location}", ex);
   }
    }

    public static void WaitSomeInterval(int seconds = 10)
    {
        Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();
    }

    public static void WaitElement(IWebDriver webDriver, By locator, int seconds = 20)
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(locator));
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementToBeClickable(locator));
    }
}