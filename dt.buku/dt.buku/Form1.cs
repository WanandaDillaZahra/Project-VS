using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace dt.buku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            koneksidatabase koneksi = new koneksidatabase();
            DataTable dt = new DataTable();
            dt = koneksi.tampil();
            dataGridView1.DataSource = dt;
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            koneksidatabase kont = new koneksidatabase();
            kont.QUERY("INSERT INTO tb_buku VALUES('" + this.dateTimePicker1.Text + "','" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text +"')");
            MessageBox.Show("insert data berhasil");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            koneksidatabase kont = new koneksidatabase();
            kont.QUERY("UPDATE tb_buku set tahun_terbit = '" + this.dateTimePicker1.Text + "', penulis = '" + this.textBox2.Text + "',penerbit='" + this.textBox3.Text + "' WHERE judul_buku='" + this.textBox1.Text + "'");
            MessageBox.Show("Update success");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            koneksidatabase kont = new koneksidatabase();
            kont.QUERY("DELETE * from tb_buku WHERE judul_buku = '" + textBox1.Text + "'");
           
            MessageBox.Show("Delete success");
        }
    }
}
