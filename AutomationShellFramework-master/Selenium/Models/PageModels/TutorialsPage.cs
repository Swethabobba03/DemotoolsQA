using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Models.PageModels
{
    public class TutorialsPage : BasePage
    {
        public TutorialsPage(IWebDriver browser) : base(browser)
        {
            _browser = browser;
        }

        public IWebElement TutorialsButton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("//*[@id='primary-menu']/li[2]/a/span/span"));
            }
        }

        
    }
}
