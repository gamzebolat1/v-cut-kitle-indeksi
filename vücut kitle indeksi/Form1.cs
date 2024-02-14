using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vücut_kitle_indeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            double boy, kilo, vki;
            boy = Convert.ToDouble(txtboy.Text);
            kilo = Convert.ToDouble(txtkilo.Text);
            vki = kilo / (boy * boy);
            vki = Math.Round(vki, 2);

            if (vki < 18.5)
            {
                lblsonuc.Text = "Sonuç: " + vki + "-> zayıf";
            }
            else if(vki >=18.5 && vki < 25)
            {
                lblsonuc.Text = "Sonuç: " + vki + "-> normal kilolu";
            }
            else if(vki>=25 && vki < 30)
            {
                lblsonuc.Text = "Sonuç: " + vki + "-> fazla kilolu";
            }
            else if (vki >=30 && vki < 35)
            {
                lblsonuc.Text = "Sonuç: " + vki + "-> obez (1.derece obezite)";
            }
            else if (vki >= 35 && vki < 40)
            {
                lblsonuc.Text = "Sonuç: " + vki + "-> aşırı obez (2.derece obezite)";
            }
            else
            {
                lblsonuc.Text = "Sonuç: " + vki + "-> morbid obez (3.derece obezite)";
            }
        }
    }
}
