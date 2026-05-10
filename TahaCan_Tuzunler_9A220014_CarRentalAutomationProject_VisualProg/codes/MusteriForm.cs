using System;
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
    public partial class MusteriForm : Form
    {
        
        AracKiralamaDBEntities db = new AracKiralamaDBEntities();

        public MusteriForm()
        {
            InitializeComponent();
        }

        

        private void btnListele_Click_1(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = db.Customers.ToList();
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
           
            {
                Customers yeniMusteri = new Customers();
                yeniMusteri.Name = txtAd.Text;
                yeniMusteri.Surname = txtSoyad.Text;
                yeniMusteri.Phone = txtTelefon.Text;
                yeniMusteri.License = txtEhliyet.Text;

                db.Customers.Add(yeniMusteri);

                
                db.SaveChanges();

                MessageBox.Show("Müşteri başarıyla eklendi.");
                Temizle();
                btnListele.PerformClick();
            }
           
            
            
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(dgvMusteriler.CurrentRow.Cells["Id"].Value.ToString());
            var silinecek = db.Customers.Find(id);
            db.Customers.Remove(silinecek);
            db.SaveChanges();
            MessageBox.Show("Müşteri silindi.");
            Temizle();
            btnListele.PerformClick();
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(dgvMusteriler.CurrentRow.Cells["Id"].Value.ToString());
            var guncellenecek = db.Customers.Find(id);

            guncellenecek.Name = txtAd.Text;
            guncellenecek.Surname = txtSoyad.Text;
            guncellenecek.Phone = txtTelefon.Text;
            guncellenecek.License = txtEhliyet.Text;

            db.SaveChanges();
            MessageBox.Show("Müşteri bilgileri güncellendi.");
            Temizle();
            btnListele.PerformClick();
        }

        private void dgvMusteriler_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dgvMusteriler.CurrentRow.Cells["Name"].Value.ToString();
            txtSoyad.Text = dgvMusteriler.CurrentRow.Cells["Surname"].Value.ToString();
            txtTelefon.Text = dgvMusteriler.CurrentRow.Cells["Phone"].Value.ToString();
            txtEhliyet.Text = dgvMusteriler.CurrentRow.Cells["License"].Value.ToString();
        }

        private void txtEhliyet_TextChanged(object sender, EventArgs e)
        {

        }

        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEhliyet.Clear(); 
        }

    }

        
}
