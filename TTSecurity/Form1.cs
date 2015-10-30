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
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Content", "Title",MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      string firstName = textBox2.Text;
      MessageBox.Show(firstName);
    }
  }
}
