using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            date_label.Text = DateTime.Now.ToString();
        }
        void Google(Object obj, EventArgs args)
        {
            webView.Source = "https://www.google.com/";
        }
        void Zajel(Object obj, EventArgs args)
        {
            webView.Source = "https://zajel.najah.edu/";
        }

        public void OnButtonClicked(object sender, EventArgs args)
        {

            label.Text = "";
            for (int i = 1990; i <= 2030; i++)
            {
                label.Text += i + "\n";
            }
        }


    }
}
