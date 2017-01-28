using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDrvNavApp.Bldrs;

namespace WebDrvNavApp
{
    public partial class WebDrvNavForm : Form
    {
        public WebDrvNavForm()
        {
            InitializeComponent();
        }

        private IWebDriver thisDriver;
        private void TestTSBtn_Click(object sender, EventArgs e)
        {
            thisDriver = new ChromeDriver(@"C:\Libraries\chromedriver");

            //thisDriver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(30));

            //thisDriver.Navigate().GoToUrl("http://localhost:58000/");

            thisDriver.Navigate().GoToUrl("http://localhost:3000/#/home");

            IWebElement myWebEl = thisDriver.FindElement(By.Id("abc"));

            myWebEl.SendKeys("abc");
            
            // Navigate
            // FindElement By (and) save Value Validate if value update Status goto nIdx or END (else) peformAction

            //IWebElement listViewMenu = thisDriver.FindElement(By.XPath("//ul//li[contains(.,'List View')]"));
            //bool myResult = (listViewMenu.GetAttribute("class").Contains("active"));
            //listViewMenu.Click();

            //// Assert 'list view' is selected
            //myResult = (listViewMenu.GetAttribute("class").Contains("active"));
            //myResult = (thisDriver.FindElement(By.ClassName("cardContainer")).Displayed);
            //myResult = (thisDriver.FindElement(By.ClassName("gridContainer")).Displayed);

            thisDriver.Quit();

        }

        private void RunScriptTSBtn_Click(object sender, EventArgs e)
        {
            string myScriptXml = ScriptBuildTB.Text;
            string myScriptNidx = RunScriptTSTB.Text;
            ScriptBldr.RunScript(myScriptXml, myScriptNidx);
        }

        private void WDInitTSBtn_Click(object sender, EventArgs e)
        {
            WDBldr.Initialize();
        }
    }
}
