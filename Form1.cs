using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vki_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(txtBoy.Text);
            double kilo = Convert.ToDouble(txtKilo.Text);
            double vki = kilo / (boy * boy);
            if(vki>0 && vki < 18.4)
            {
                MessageBox.Show("zayıf   :" + vki.ToString());
            }else if (vki > 18.5 && vki < 24.9)
            {
                MessageBox.Show("normal    :" + vki.ToString());
            }
            else
            {
                MessageBox.Show("fazla kilolu       :".ToString());
            }
        }
    }
}
