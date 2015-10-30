namespace TTSecurity
{
  partial class WebBrowser
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.navigateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.goForwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.button1 = new System.Windows.Forms.Button();
      this.webBrowser1 = new System.Windows.Forms.WebBrowser();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigateToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(810, 25);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // navigateToolStripMenuItem
      // 
      this.navigateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.goBackToolStripMenuItem,
            this.goForwardToolStripMenuItem});
      this.navigateToolStripMenuItem.Name = "navigateToolStripMenuItem";
      this.navigateToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
      this.navigateToolStripMenuItem.Text = "Navigate";
      // 
      // homeToolStripMenuItem
      // 
      this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
      this.homeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.homeToolStripMenuItem.Text = "Home";
      this.homeToolStripMenuItem.Click += new System.EventHandler(this.MenuItemHome_Click);
      // 
      // goBackToolStripMenuItem
      // 
      this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
      this.goBackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.goBackToolStripMenuItem.Text = "Go Back";
      this.goBackToolStripMenuItem.Click += new System.EventHandler(this.MenuItemGoBack_Click);
      // 
      // goForwardToolStripMenuItem
      // 
      this.goForwardToolStripMenuItem.Name = "goForwardToolStripMenuItem";
      this.goForwardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.goForwardToolStripMenuItem.Text = "Go Forward";
      this.goForwardToolStripMenuItem.Click += new System.EventHandler(this.MenuItemGoForward_Click);
      // 
      // comboBox1
      // 
      this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "http://www.baidu.com",
            "http://www.qq.com"});
      this.comboBox1.Location = new System.Drawing.Point(12, 28);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(702, 20);
      this.comboBox1.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.AutoSize = true;
      this.button1.Location = new System.Drawing.Point(720, 28);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Go";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button_Click);
      // 
      // webBrowser1
      // 
      this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.webBrowser1.Location = new System.Drawing.Point(12, 57);
      this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.Size = new System.Drawing.Size(783, 370);
      this.webBrowser1.TabIndex = 3;
      // 
      // WebBrowser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(810, 439);
      this.Controls.Add(this.webBrowser1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "WebBrowser";
      this.Text = "Web Browser";
      this.Load += new System.EventHandler(this.WebBrowser_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem navigateToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem goForwardToolStripMenuItem;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.WebBrowser webBrowser1;
  }
}