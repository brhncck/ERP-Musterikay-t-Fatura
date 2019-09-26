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
    public partial class Cari : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9UJ1BLT\\SQLEXPRESS;Initial Catalog=mikro;Integrated Security=True");
       



        public Cari()
        {
            InitializeComponent();
        }

        private void Cari_Load(object sender, EventArgs e)
        {

        }

        private void btnCariKaydet_Click(object sender, EventArgs e)
        {
           if (baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO tblCari(CariUnvan,VergiKimlikNumarasi,Adres,Email,TelefonNumarasi) VALUES('"+ txtCUnvan.Text + "','" + int.Parse(txtCVKN.Text) + "','" + txtCAdres.Text + "','" + txtCEmail.Text + "','" + int.Parse(txtCTelNo.Text) + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Eklendi");
            }
            
        }

       

        private void btnLisstCari_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "Select * from tblCari";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "tblCari");
                gridCari.DataSource = ds.Tables["tblCari"];
                baglanti.Close();

            }
        }

        private void btnCariSec_Click(object sender, EventArgs e)
        {
            Form form1 = new Stok();
            form1.Show();


            this.Hide();

            
        }
    }
}
