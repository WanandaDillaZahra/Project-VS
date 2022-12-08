using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace dt.buku
{
    class koneksidatabase
    {
        string database = "provider=Microsoft.ACE.OLEDB.12.0;Data Source= databuku.accdb";
        string sql = " SELECT * FROM tb_buku";
        public OleDbConnection koneksi;
        public OleDbCommand perintah;
        public OleDbDataAdapter adp;
        public void connect()
        {
            koneksi = new OleDbConnection(database);
            koneksi.Open();

        }
        public void disconected()
        {
            koneksi = new OleDbConnection(database);
            koneksi.Close();
        }

        public DataTable tampil()
        {
            DataTable dt = new DataTable();
            try
            {
                connect();
                perintah = new OleDbCommand(sql, koneksi);
                adp = new OleDbDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }
        public void QUERY(string query)
        {
            try
            {
                connect();
                perintah = new OleDbCommand(query, koneksi);
                perintah.ExecuteNonQuery();
            }
            catch (Exception ali)
            {
                MessageBox.Show(ali.Message);
            }
            finally
            {
                disconected();
            }
        }
    }
}
