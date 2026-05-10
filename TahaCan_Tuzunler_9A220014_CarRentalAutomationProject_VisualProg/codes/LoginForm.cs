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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            using (AracKiralamaDBEntities db = new AracKiralamaDBEntities())
            {
                
                string kadi = txtKullaniciAdi.Text;
                string sifre = txtSifre.Text;

               
                var admin = db.Admins.FirstOrDefault(x => x.UserName == kadi && x.Password == sifre);

                if (admin != null)
                {
                    MessageBox.Show("Giriş Başarılı! Hoş geldiniz.");

                    if (admin != null)
                    {
                        MessageBox.Show("Giriş Başarılı! Hoş geldiniz.");

                        
                        AnaMenu frm = new AnaMenu();
                        frm.Show(); 
                    }

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı! Lütfen tekrar deneyin.");
                }
            }
        }
    }
}
