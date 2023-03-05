using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora_Simples
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtEx(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            int a = Convert.ToInt32(etValorA.Text);
            int b = Convert.ToInt32(etValorB.Text);
            int t = 0;
            if (bt.Text == "+")
            {
                t = a + b;
            }
            if (bt.Text == "-")
            {
                t = a - b;
            }
            if (bt.Text == "/")
            {
                t = a / b;
            }
            if (bt.Text == "*")
            {
                t = a * b;
            }
            lbResp.Text = t.ToString();
        }
    }
}
