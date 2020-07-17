using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertSite
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      webBrowser1.Navigate(textBox1.Text);
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      webBrowser1.Document.GetElementById("tfDataIn").SetAttribute("value", "2019-09-21");
      webBrowser1.Document.GetElementById("tfDataF").SetAttribute("value", "2019-09-30");
      webBrowser1.Document.GetElementById("Lit").SetAttribute("value", "10");
      webBrowser1.Document.GetElementById("Kms").SetAttribute("value", "350");
      webBrowser1.Document.GetElementById("cars").SetAttribute("option", "2");

      //webBrowser1.Document.GetElementById("ctl00$ContentPlaceHolder$txtCNPJ").SetAttribute("value", "01927411602");
      //webBrowser1.Document.GetElementById("ctl00$ContentPlaceHolder$txtCPFResponsavel").SetAttribute("value", "79842208672");
      //webBrowser1.Document.GetElementById("ctl00$ContentPlaceHolder$txtCodigoAcesso").SetAttribute("value", "355654650");

    }

    private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
      this.Text = e.Url.ToString();
      //HtmlElement htt = webBrowser1.Document.All.GetElementsByName("USTRAbalho"))
      // webBrowser1.Document.GetElementById("tfDataIn").SetAttribute("value", "25/09/2019");
      // MessageBox.Show(webBrowser1.Document.All.GetElementsByName("cars").ToString());

    }

    private void Button3_Click(object sender, EventArgs e)
    {
      webBrowser1.Document.GetElementById("btnSalva").InvokeMember("click");

      //MessageBox.Show(webBrowser1.Document.GetElementById("cars").GetAttribute("Option").ToString());
    }
  }
}
