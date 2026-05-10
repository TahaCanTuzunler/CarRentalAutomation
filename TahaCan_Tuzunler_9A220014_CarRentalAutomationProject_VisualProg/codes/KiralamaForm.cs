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
    public partial class KiralamaForm : Form
    {
        
        AracKiralamaDBEntities db = new AracKiralamaDBEntities();

        public KiralamaForm()
        {
            InitializeComponent();
        }

        
        private void Listele()
        {
            dgvKiralamalar.DataSource = db.Rentals.ToList();
        }
      

        

        private void btnHesapla_Click_1(object sender, EventArgs e)
        {
            TimeSpan gunFarki = dtpBitis.Value - dtpBaslangic.Value;
            int gun = (int)gunFarki.TotalDays;
            if (gun <= 0) gun = 1;

            
            var seciliArac = db.Cars.Find((int)cmbAraclar.SelectedValue);
            decimal toplam = (decimal)(gun * seciliArac.DailyCost);
            txtToplamTutar.Text = toplam.ToString();
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            Rentals kiralama = new Rentals();
            kiralama.CarId = (int)cmbAraclar.SelectedValue;
            kiralama.CustomerId = (int)cmbMusteriler.SelectedValue;
            kiralama.StartDate = dtpBaslangic.Value;
            kiralama.ReturnDate = dtpBitis.Value;
            kiralama.TotalCost = decimal.Parse(txtToplamTutar.Text);

            
            var arac = db.Cars.Find(kiralama.CarId);
            arac.Available = false;

            db.Rentals.Add(kiralama);
            db.SaveChanges();
            MessageBox.Show("Araç başarıyla kiralandı.");
            Listele();
        }

        private void btnListele_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (dgvKiralamalar.CurrentRow == null) return;

            int id = int.Parse(dgvKiralamalar.CurrentRow.Cells["Id"].Value.ToString());
            var guncelle = db.Rentals.Find(id);

            guncelle.StartDate = dtpBaslangic.Value;
            guncelle.ReturnDate = dtpBitis.Value;
            guncelle.TotalCost = decimal.Parse(txtToplamTutar.Text);

            db.SaveChanges();
            MessageBox.Show("Kiralama güncellendi.");
            Listele();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (dgvKiralamalar.CurrentRow == null) return;

            int id = int.Parse(dgvKiralamalar.CurrentRow.Cells["Id"].Value.ToString());
            var silinecek = db.Rentals.Find(id);

            
            var arac = db.Cars.Find(silinecek.CarId);
            arac.Available = true;

            db.Rentals.Remove(silinecek);
            db.SaveChanges();
            MessageBox.Show("Kiralama iptal edildi.");
            Listele();
        }

        private void KiralamaForm_Load_1(object sender, EventArgs e)
        {
            cmbAraclar.DataSource = db.Cars.Where(x => x.Available == true).ToList();
            cmbAraclar.DisplayMember = "Model";
            cmbAraclar.ValueMember = "Id";

            cmbMusteriler.DataSource = db.Customers.ToList();
            cmbMusteriler.DisplayMember = "Name";
            cmbMusteriler.ValueMember = "Id";

            Listele();
        }
    }
}
