using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTSecurity
{
  public partial class WebBrowser : Form
  {
    public WebBrowser()
    {
      InitializeComponent();
    }

    private void button_Click(object sender, EventArgs e)
    {
      string url = comboBox1.SelectedItem.ToString();
      webBrowser1.Navigate(new Uri(url));
    }

    private void WebBrowser_Load(object sender, EventArgs e)
    {
      this.AutoSize = true;
      this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

      comboBox1.SelectedIndex = 0;
      webBrowser1.GoHome();
    }

    private void MenuItemHome_Click(object sender, EventArgs e)
    {
      webBrowser1.GoHome();
    }


    private void MenuItemGoBack_Click(object sender, EventArgs e)
    {
      webBrowser1.GoBack();
      
    }


    private void MenuItemGoForward_Click(object sender, EventArgs e)
    {
      webBrowser1.GoForward();
    }
  }
}
