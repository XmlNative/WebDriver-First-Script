namespace WebDrvNavApp
{
    partial class WebDrvScriptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebDrvScriptForm));
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.WDInitTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.OpenFileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsFileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RunScriptTSTB = new System.Windows.Forms.ToolStripTextBox();
            this.RunScriptTSBtn = new System.Windows.Forms.ToolStripButton();
            this.FormatScriptTSBtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MessageTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ScriptBuildTB = new System.Windows.Forms.TextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.RunAllScriptTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip4
            // 
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WDInitTSBtn,
            this.toolStripSeparator2,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.RunScriptTSTB,
            this.RunScriptTSBtn,
            this.FormatScriptTSBtn,
            this.toolStripSeparator3,
            this.RunAllScriptTSBtn});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(613, 25);
            this.toolStrip4.TabIndex = 2;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // WDInitTSBtn
            // 
            this.WDInitTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WDInitTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("WDInitTSBtn.Image")));
            this.WDInitTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WDInitTSBtn.Name = "WDInitTSBtn";
            this.WDInitTSBtn.Size = new System.Drawing.Size(50, 22);
            this.WDInitTSBtn.Text = "WD Init";
            this.WDInitTSBtn.Click += new System.EventHandler(this.WDInitTSBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DoubleClickEnabled = true;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileTSMI,
            this.SaveAsFileTSMI});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // OpenFileTSMI
            // 
            this.OpenFileTSMI.Name = "OpenFileTSMI";
            this.OpenFileTSMI.Size = new System.Drawing.Size(152, 22);
            this.OpenFileTSMI.Text = "Open...";
            this.OpenFileTSMI.Click += new System.EventHandler(this.OpenFileTSMI_Click);
            // 
            // SaveAsFileTSMI
            // 
            this.SaveAsFileTSMI.Name = "SaveAsFileTSMI";
            this.SaveAsFileTSMI.Size = new System.Drawing.Size(152, 22);
            this.SaveAsFileTSMI.Text = "Save As...";
            this.SaveAsFileTSMI.Click += new System.EventHandler(this.SaveAsFileTSMI_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // RunScriptTSTB
            // 
            this.RunScriptTSTB.Name = "RunScriptTSTB";
            this.RunScriptTSTB.Size = new System.Drawing.Size(100, 25);
            // 
            // RunScriptTSBtn
            // 
            this.RunScriptTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RunScriptTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("RunScriptTSBtn.Image")));
            this.RunScriptTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RunScriptTSBtn.Name = "RunScriptTSBtn";
            this.RunScriptTSBtn.Size = new System.Drawing.Size(32, 22);
            this.RunScriptTSBtn.Text = "Run";
            this.RunScriptTSBtn.Click += new System.EventHandler(this.RunScriptTSBtn_Click);
            // 
            // FormatScriptTSBtn
            // 
            this.FormatScriptTSBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.FormatScriptTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FormatScriptTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("FormatScriptTSBtn.Image")));
            this.FormatScriptTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FormatScriptTSBtn.Name = "FormatScriptTSBtn";
            this.FormatScriptTSBtn.Size = new System.Drawing.Size(49, 22);
            this.FormatScriptTSBtn.Text = "Format";
            this.FormatScriptTSBtn.Click += new System.EventHandler(this.FormatScriptTSBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessageTSSL,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(613, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MessageTSSL
            // 
            this.MessageTSSL.Name = "MessageTSSL";
            this.MessageTSSL.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // ScriptBuildTB
            // 
            this.ScriptBuildTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptBuildTB.Location = new System.Drawing.Point(0, 25);
            this.ScriptBuildTB.Multiline = true;
            this.ScriptBuildTB.Name = "ScriptBuildTB";
            this.ScriptBuildTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ScriptBuildTB.Size = new System.Drawing.Size(613, 410);
            this.ScriptBuildTB.TabIndex = 4;
            this.ScriptBuildTB.WordWrap = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // RunAllScriptTSBtn
            // 
            this.RunAllScriptTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RunAllScriptTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("RunAllScriptTSBtn.Image")));
            this.RunAllScriptTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RunAllScriptTSBtn.Name = "RunAllScriptTSBtn";
            this.RunAllScriptTSBtn.Size = new System.Drawing.Size(49, 22);
            this.RunAllScriptTSBtn.Text = "Run All";
            this.RunAllScriptTSBtn.Click += new System.EventHandler(this.RunAllScriptTSBtn_Click);
            // 
            // WebDrvScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 457);
            this.Controls.Add(this.ScriptBuildTB);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip4);
            this.Name = "WebDrvScriptForm";
            this.Text = "WebDrv Script";
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem OpenFileTSMI;
        private System.Windows.Forms.ToolStripMenuItem SaveAsFileTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox RunScriptTSTB;
        private System.Windows.Forms.ToolStripButton RunScriptTSBtn;
        private System.Windows.Forms.ToolStripButton FormatScriptTSBtn;
        private System.Windows.Forms.ToolStripButton WDInitTSBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox ScriptBuildTB;
        private System.Windows.Forms.ToolStripStatusLabel MessageTSSL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton RunAllScriptTSBtn;
    }
}