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
using System.Collections;

namespace Mikromax
{
    public partial class FaturaEvrak : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9UJ1BLT\\SQLEXPRESS;Initial Catalog=mikro;Integrated Security=True");

        public FaturaEvrak()
        {
            InitializeComponent();
        }



        private void btnCariList_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from tblCari";
                cmd.Connection = baglanti;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                for (int i = 0; i < tablo.Rows.Count; i++)
                {
                    listView1.Items.Add(tablo.Rows[i]["CKod"].ToString());
                    listView1.Items[i].SubItems.Add(tablo.Rows[i]["CariUnvan"].ToString());

                }
                baglanti.Close();


            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                if (listView1.SelectedItems.Count > 0)
                {

                    int a = listView1.SelectedIndices[0];
                    lblCKod.Text = "" + (a + 1);
                    SqlCommand cmd = new SqlCommand("select CKod from tblCari where ");
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataSet ds = new DataSet();


                }

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
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
                GridStok.DataSource = ds.Tables["tblStok"];
                baglanti.Close();

            }
        }

        private void btnStokList_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from tblStok";
                cmd.Connection = baglanti;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                for (int i = 0; i < tablo.Rows.Count; i++)
                {
                    listView2.Items.Add(tablo.Rows[i]["StokKod"].ToString());
                    listView2.Items[i].SubItems.Add(tablo.Rows[i]["StokIsim"].ToString());

                }
                baglanti.Close();


            }
        }
    }
}
