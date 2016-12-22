using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Övning3
{
    class Program
    {
        static IWebDriver driver;
        static void Main(string[] args)
        {
            driver = new FirefoxDriver();

            driver.Url = "http://www.Lyko.se";
            Thread.Sleep(2000);

            driver.FindElement(By.Name("q")).SendKeys("Schampoo");
            Thread.Sleep(4000);
            driver.FindElement(By.ClassName("A69wSs")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("div._1Nvacq:nth-child(1) > button:nth-child(2) > span:nth-child(1)")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.CssSelector("._1w9fSZ")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("a._3itYIP:nth-child(1)")).Click();
            Thread.Sleep(3000);
            for (int i = 0; i < 9; i++)
            {
                Thread.Sleep(200);
                driver.FindElement(By.CssSelector(".YwJvmF")).Click(); 
            }
            Thread.Sleep(3000);

            if (driver.FindElement(By.CssSelector(".jmb20U")).Displayed)
            {
                Console.WriteLine("Loggan fanns");
                driver.FindElement(By.CssSelector(".jmb20U")).Click();
            }
            else
            {
                Console.WriteLine("Loggan fanns inte");
            }
        }
    }
}
