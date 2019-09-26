using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mikromax
{
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9UJ1BLT\\SQLEXPRESS;Initial Catalog=mikro;Integrated Security=True");

        private void btnStokKaydet_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO tblStok(StokIsim,StokFiyat,StokVergiOrani,StokBirimi) VALUES('" + txtSIsim.Text + "','" + float.Parse(txtSFiyat.Text) + "','" + float.Parse(txtSVergiOrani.Text) + "','" + txtSBirim.Text + "')";
                cmd.ExecuteNonQuery(); cmd.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Eklendi");
            }
        }

        private void btnStokList_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "Select * from tblStok";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "tblStok");
                gridStok.DataSource = ds.Tables["tblStok"];
                baglanti.Close();

            }
        }

        private void btnStokSec_Click(object sender, EventArgs e)
        {
            Form form1 = new FaturaEvrak();
            form1.Show();


            this.Hide();
        }

        private void Stok_Load(object sender, EventArgs e)
        {

        }
    }
}
