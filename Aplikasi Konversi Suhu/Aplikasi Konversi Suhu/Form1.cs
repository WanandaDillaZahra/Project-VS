using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplikasi_Konversi_Suhu
{
    public partial class Form1 : Form
    {
        string a, b, c;

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            a = textBox1.Text;
            b = comboBox1.Text;
            c = comboBox2.Text;
            g = Convert.ToDouble(a);
            if ((b.Equals("celcius")) && (c.Equals("reamur")))
            {
                hitung = g / 5 * 4;
                textBox2.Text = hitung.ToString();
            }
            else if ((b.Equals("celcius")) && (c.Equals("fahrenheit")))
            {
                hitung = g / 5 * 9 + 32;
                textBox2.Text = hitung.ToString();
            }
            else if ((b.Equals("celsius")) && (c.Equals("kelvin")))
            {
                hitung = g / +273.15;
                textBox2.Text = hitung.ToString();
            }
            else if ((b.Equals("reamur")) && (c.Equals("celcius")))
        }

        double g, hitung;
        public Form1()
        {
            InitializeComponent();
        }
    }
}
