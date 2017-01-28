using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WebDrvNavApp.Bldrs
{
    class ScriptBldr
    {
        static XmlDocument TheScriptDoc = new XmlDocument();
        internal static string RunScript(string aScriptXml, string aScriptNidx)
        {
            string retString = string.Empty;

            if (aScriptXml == string.Empty)
            {
                retString = "Script is empty";
                return retString;
            }

            TheScriptDoc.LoadXml(aScriptXml);
            XmlElement myScriptDocEl = TheScriptDoc.DocumentElement;

            if (!aScriptNidx.Contains("-"))
            {
                String mySelect = "//*[@nIdx='" + aScriptNidx + "']";
                XmlElement myStepEl = (XmlElement)myScriptDocEl.SelectSingleNode(mySelect);
                if (myStepEl == null)
                {
                    retString = "Step not found";
                    return retString;
                }

                RunScriptStep(myStepEl);
                return retString;
            }
            try
            {
                string[] myLowHigh = aScriptNidx.Split(new[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
                string myLowIndxStr = myLowHigh[0];
                string myHighIndxStr = myLowHigh[1];

                int myLowIndx = Convert.ToInt32(myLowIndxStr);
                int myHighIndx = Convert.ToInt32(myHighIndxStr);

                string myXPath = "//*[@nIdx >= " + myLowIndx + " and @nIdx <= " + myHighIndx + "]";
                XmlNodeList myStepsNL = myScriptDocEl.SelectNodes(myXPath);
                if (myStepsNL.Count == 0)
                    retString = "Steps not found";
                foreach (XmlElement eachStepEl in myStepsNL)
                {
                    RunScriptStep(eachStepEl);
                }
            }
            catch
            {
                retString = "Invalid Index";
            }


            return retString;
        }

        internal static string RunAllScript(string aScriptXml)
        {
            string retString = string.Empty;

            if (aScriptXml == string.Empty)
            {
                retString = "Script is empty";
                return retString;
            }

            TheScriptDoc.LoadXml(aScriptXml);
            XmlElement myScriptDocEl = TheScriptDoc.DocumentElement;

            try
            {
                string myXPath = "./*";
                XmlNodeList myStepsNL = myScriptDocEl.SelectNodes(myXPath);
                if (myStepsNL.Count == 0)
                    retString = "Steps not found";
                foreach (XmlElement eachStepEl in myStepsNL)
                {
                    RunScriptStep(eachStepEl);
                }
            }
            catch
            {
                retString = "Invalid Step";
            }


            return retString;
        }

        private static void RunScriptStep(XmlElement aStepEl)
        {
            string myStepName = aStepEl.Name;

            string myMethod = aStepEl.GetAttribute("method");
            switch (myStepName)
            {
                case "WDriver":
                    switch (myMethod)
                    {
                        case "NavGoToUrl":
                            WDBldr.NavGoToUrl(aStepEl);
                            break;
                        case "FindElement":
                            WDBldr.FindElement(aStepEl);
                            break;
                    }

                    break;
                case "WElement":
                    switch (myMethod)
                    {
                        case "Click":
                            WDBldr.Click(aStepEl);
                            break;
                        case "SendKeys":
                            WDBldr.SendKeys(aStepEl);
                            break;
                    }

                    break;
            }
        }
    }
}
