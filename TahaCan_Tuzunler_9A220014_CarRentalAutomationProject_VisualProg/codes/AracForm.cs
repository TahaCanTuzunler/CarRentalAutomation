using System;
using System.Data.SqlClient; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalAutomation
{
    public partial class AracForm : Form
    {
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AracKiralamaDB;Integrated Security=True;TrustServerCertificate=True");

        public AracForm()
        {
            InitializeComponent();
        }

        
        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cars", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAraclar.DataSource = dt; 
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Cars (Plate, Model, DailyCost, BrandId, Available) VALUES (@p1, @p2, @p3, @p4, @p5)", baglanti);

                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", txtModel.Text);
                komut.Parameters.AddWithValue("@p3", decimal.Parse(txtUcret.Text));
                komut.Parameters.AddWithValue("@p4", int.Parse(txtMarkaId.Text)); 
                komut.Parameters.AddWithValue("@p5", true); 

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Araç başarıyla eklendi!");

                txtPlaka.Text = "";
                txtModel.Text = "";
                txtUcret.Text = "";
                txtMarkaId.Text = "";

                btnListele_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme başarısız! Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        private void dgvAraclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaka.Text = dgvAraclar.CurrentRow.Cells["Plate"].Value.ToString();
            txtModel.Text = dgvAraclar.CurrentRow.Cells["Model"].Value.ToString();
            txtUcret.Text = dgvAraclar.CurrentRow.Cells["DailyCost"].Value.ToString();
            txtMarkaId.Text = dgvAraclar.CurrentRow.Cells["BrandId"].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Cars WHERE Plate=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Araç başarıyla silindi.");

                txtPlaka.Text = "";
                txtModel.Text = "";
                txtUcret.Text = "";
                txtMarkaId.Text = "";

                btnListele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
                baglanti.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                
                string sorgu = "UPDATE Cars SET Model=@p1, DailyCost=@p2, BrandId=@p3 WHERE Plate=@p4";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", txtModel.Text);
                komut.Parameters.AddWithValue("@p2", decimal.Parse(txtUcret.Text));
                komut.Parameters.AddWithValue("@p3", int.Parse(txtMarkaId.Text));
                komut.Parameters.AddWithValue("@p4", txtPlaka.Text); 

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Araç bilgileri başarıyla güncellendi.");

                txtPlaka.Text = "";
                txtModel.Text = "";
                txtUcret.Text = "";
                txtMarkaId.Text = "";

                btnListele.PerformClick(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
                baglanti.Close();
            }
        }
    }
}
