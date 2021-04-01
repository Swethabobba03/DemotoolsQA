using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Models.PageModels
{
    public class ElementsPage : BasePage
    {
        public ElementsPage(IWebDriver browser) : base(browser)
        {
            _browser = browser;
        }

        public IWebElement ElementsButton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("/html/body/div/div/div/div[2]/div/div[1]"));
            }
        }

        public IWebElement TextBoxButton
        {
            get
            {
                return _seleniumExtGeneral.FindElementBy(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[1]/span"));
            }
        }
    }
}
