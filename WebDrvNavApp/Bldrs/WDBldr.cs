using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Xml;

namespace WebDrvNavApp.Bldrs
{
    class WDBldr
    {
        static public Dictionary<string, IWebElement> TheWebElDict = new Dictionary<string, IWebElement>();
        static public IWebDriver TheWebDriver;
        static private string TheBrowserType = "Chrome";

        internal static bool IsInitialized()
        {
            bool retIsInit = false;

            if (TheWebDriver != null)
                retIsInit = true;   
            return retIsInit;
        }

        internal static void Initialize()
        {
            try
            {
                if (TheWebDriver == null)
                    TheWebDriver = CreateWebDriver(TheBrowserType);
            }
            catch (Exception exc)
            {
                string myExc = exc.ToString();
                return;
            }
        }

        private static IWebDriver CreateWebDriver(string TheBrowserType)
        {
            IWebDriver retWebDriver = null;

            try
            {
                switch (TheBrowserType)
                {
                    case "Chrome":
                        ChromeOptions myChromeOpts = new ChromeOptions();
                        myChromeOpts.AddArgument("--test-type");
                        myChromeOpts.AddArgument("--disable-extensions");
                        myChromeOpts.AddArgument("--disable-popup-blocking");
                        retWebDriver = new ChromeDriver(@".\Libraries\chromedriver", myChromeOpts);
                        break;
                }

                retWebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
            }
            catch (Exception exc)
            {
                string myExc = exc.ToString();
                throw exc;
            }

            return retWebDriver;
        }

        internal static void NavGoToUrl(XmlElement aStepEl)
        {
            string myUrl = aStepEl.GetAttribute("url");
            TheWebDriver.Navigate().GoToUrl(myUrl);
        }

        internal static void FindElement(XmlElement aStepEl)
        {
            By myBy = GenBy(aStepEl);
            IWebElement myWebEl = TheWebDriver.FindElement(myBy);

            string myPageElement = aStepEl.GetAttribute("pageElement");
            TheWebElDict.Remove(myPageElement);
            TheWebElDict.Add(myPageElement, myWebEl);

        }

        private static By GenBy(XmlElement aStepEl)
        {
            By retBy = null;
            string myByType = aStepEl.GetAttribute("by");

            switch (myByType)
            {
                case ("XPath"):
                    string myXPath = aStepEl.GetAttribute("xpath");
                    retBy = By.XPath(myXPath);
                    break;
                case ("LinkText"):
                    string myLinkText = aStepEl.GetAttribute("linkText");
                    retBy = By.LinkText(myLinkText);
                    break;
            }
            return retBy;
        }

        internal static void Click(XmlElement aStepEl)
        {
            string myPageElement = aStepEl.GetAttribute("pageElement");
            IWebElement myWebEl = TheWebElDict[myPageElement];
            myWebEl.Click();
        }

        internal static void SendKeys(XmlElement aStepEl)
        {
            string myPageElement = aStepEl.GetAttribute("pageElement");
            IWebElement myWebEl = TheWebElDict[myPageElement];
            string myKeys = aStepEl.GetAttribute("keys");
            myWebEl.SendKeys(myKeys);
        }
    }
}
