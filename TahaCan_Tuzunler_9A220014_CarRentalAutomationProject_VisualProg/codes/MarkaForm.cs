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
    public partial class MarkaForm : Form
    {
        
        AracKiralamaDBEntities db = new AracKiralamaDBEntities();

        public MarkaForm()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            dgvMarkalar.DataSource = db.Brands.ToList();
        }

        private void MarkaForm_Load(object sender, EventArgs e)
        {
            Listele();
        }


        private void dgvMarkalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMarkaAd.Text = dgvMarkalar.CurrentRow.Cells["BrandName"].Value.ToString();
        }


        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            Brands yeniMarka = new Brands();
            yeniMarka.BrandName = txtMarkaAd.Text;

            db.Brands.Add(yeniMarka);
            db.SaveChanges();
            MessageBox.Show("Yeni marka eklendi.");
            Listele();
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(dgvMarkalar.CurrentRow.Cells["Id"].Value.ToString());
            var guncelle = db.Brands.Find(id);
            guncelle.BrandName = txtMarkaAd.Text;

            db.SaveChanges();
            MessageBox.Show("Marka güncellendi.");
            Listele();
        }

        private void btnListele_Click_1(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(dgvMarkalar.CurrentRow.Cells["Id"].Value.ToString());
            var silinecek = db.Brands.Find(id);

            db.Brands.Remove(silinecek);
            db.SaveChanges();
            MessageBox.Show("Marka silindi.");
            Listele();
        }
    }
}