using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpGoogleSelenium
{
    // TODO 1. Skapa en main
    // TODO 2. hämta plugin
    // TODO 3. Hitta sökfältet
    // TODO 4. Sök efter "Testautomatisering Stockholm"
    // TODO 5. Hitta sök knappen klicka på den
    // TODO 6. Ta fram resultatstats och skriv ut de
    class Program
    {
        // Skapa en variabel som hållerwebdriver
        static IWebDriver driver;
        // Wait map
        //static IWait<IWebDriver> wait;

        static void Main(string[] args)
        {
            // Ställa in driver till att använda Firefox
            driver = new FirefoxDriver();
            // Öppna google
            driver.Url = "http://www.google.com";
            // Ställa in webdrivewait med driver den ska använda och antalet sekunder den ska vänta
            //wait = new WebDriverWait(driver, 3);
            Thread.Sleep(2000);
            // Hitta sök fältet och skriv in "Testautomatisering Stockholm"
            driver.FindElement(By.Id("lst-ib")).SendKeys("Testautomatisering Stockholm");
            // Hitta sök knappen, klicka på den
            driver.FindElement(By.Id("_fZl")).Click();
            // Vänta tills dess att elementet är synligt
            Thread.Sleep(2000);
            IWebElement results = driver.FindElement(By.Id("resultStats"));
            // Ta fram resultatstats och skriv ut
            Console.WriteLine(results.Text);
            Console.ReadLine();
        }
    }
}
