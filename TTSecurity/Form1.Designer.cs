namespace TTSecurity
{
  partial class Form1
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
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.listView1 = new System.Windows.Forms.ListView();
      this.button2 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(595, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Calculate";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 12);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(577, 21);
      this.textBox1.TabIndex = 1;
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 12;
      this.listBox1.Location = new System.Drawing.Point(12, 39);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(658, 88);
      this.listBox1.TabIndex = 2;
      // 
      // listView1
      // 
      this.listView1.Location = new System.Drawing.Point(13, 134);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(657, 97);
      this.listView1.TabIndex = 3;
      this.listView1.UseCompatibleStateImageBehavior = false;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(53, 349);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(166, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = "Get TextBox Data";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 306);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 12);
      this.label1.TabIndex = 5;
      this.label1.Text = "Name:";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(53, 306);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(166, 21);
      this.textBox2.TabIndex = 6;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(682, 461);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.listView1);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "TTSecurity";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox2;
  }
}

