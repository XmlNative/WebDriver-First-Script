using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WebDrvNavApp.Bldrs;

namespace WebDrvNavApp
{
    public partial class WebDrvScriptForm : Form
    {
        public WebDrvScriptForm()
        {
            InitializeComponent();
        }

        private void WDInitTSBtn_Click(object sender, EventArgs e)
        {
            MessageTSSL.Text = string.Empty;
            WDBldr.Initialize();
        }

        private void RunScriptTSBtn_Click(object sender, EventArgs e)
        {
            MessageTSSL.Text = string.Empty;
            try
            {
                if (!WDBldr.IsInitialized())
                {
                    MessageTSSL.Text = "Web Driver not initialized";
                    return;
                }

                string myScriptXml = ScriptBuildTB.Text;
                string myScriptNidx = RunScriptTSTB.Text;
                string myMsg = ScriptBldr.RunScript(myScriptXml, myScriptNidx);
                MessageTSSL.Text = myMsg;
            }
            catch (Exception ee)
            {
                MessageTSSL.Text = "Invalid Xml";
            }
        }

        private void RunAllScriptTSBtn_Click(object sender, EventArgs e)
        {
            MessageTSSL.Text = string.Empty;
            try
            {
                if (!WDBldr.IsInitialized())
                {
                    MessageTSSL.Text = "Web Driver not initialized";
                    return;
                }

                string myScriptXml = ScriptBuildTB.Text;
                string myMsg = ScriptBldr.RunAllScript(myScriptXml);
                MessageTSSL.Text = myMsg;
            }
            catch (Exception ee)
            {
                MessageTSSL.Text = "Invalid Xml";
            }
        }


        static XmlDocument thisPrettyDoc = new XmlDocument();
        private void FormatScriptTSBtn_Click(object sender, EventArgs e)
        {
            MessageTSSL.Text = string.Empty;
            string myXmlStr = ScriptBuildTB.Text;
            try
            {
                StringWriter myWriter = new StringWriter();
                XmlTextWriter myTextWriter = new XmlTextWriter(myWriter);
                myTextWriter.Formatting = Formatting.Indented;
                myTextWriter.Indentation = 6;
                thisPrettyDoc.LoadXml(myXmlStr);
                thisPrettyDoc.Save(myTextWriter);
                myXmlStr = myWriter.ToString();
                myTextWriter.Close();
                myWriter.Close();

                ScriptBuildTB.Text = myXmlStr;
            }
            catch (SystemException eFormatScript)
            {
                MessageTSSL.Text = "Invalid Xml";
            }
        }

        private void OpenFileTSMI_Click(object sender, EventArgs e)
        {
            MessageTSSL.Text = string.Empty;
            OpenFileDialog myOFD = new OpenFileDialog();
            myOFD.InitialDirectory = "./TestData";
            myOFD.Filter = "xml file (*.xml)|*.xml";
            if (myOFD.ShowDialog() != DialogResult.OK)
                return;
            string myFileName = myOFD.FileName;
            ScriptBuildTB.Text = File.ReadAllText(myFileName);
        }

        private void SaveAsFileTSMI_Click(object sender, EventArgs e)
        {
            MessageTSSL.Text = string.Empty;
            SaveFileDialog mySFD = new SaveFileDialog();
            mySFD.InitialDirectory = "./TestData";
            mySFD.Filter = "xml file (*.xml)|*.xml";
            if (mySFD.ShowDialog() != DialogResult.OK)
                return;
            string myFileName = mySFD.FileName;
            File.WriteAllText(myFileName, ScriptBuildTB.Text);
        }



    }
}
