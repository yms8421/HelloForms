using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.HelloForms
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            var control1 = double.TryParse(txtNumber1.Text, out double number1);
            var control2 = double.TryParse(txtNumber2.Text, out double number2);
            if (control1 && control2)
            {
                var sum = number1 + number2;
                txtSum.Text = sum.ToString();
            }
            else
            {
                txtSum.Clear();
                MessageBox.Show("Sayılar matematiksel ifade taşımıyor");
            }
        }
        //event methodları için :
        //                  sender => methodu çağıran kontrol
        //                  e      => methoda özel durumlar
        private void CheckNumericInput(object sender, KeyPressEventArgs e)
        {
            //eğer basılan tuş sayısal değilse yazdırma
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;//kontrole yazdırma
            }

            //e.Handled = char.IsNumber(e.KeyChar);
        }
    }
}
