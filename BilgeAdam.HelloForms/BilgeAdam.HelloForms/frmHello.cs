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
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                //MessageBox.Show("Merhaba, " + txtName.Text);
                MessageBox.Show("Merhaba, " + txtName.Text, "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bir isim giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtName.Clear();
        }
    }
}
