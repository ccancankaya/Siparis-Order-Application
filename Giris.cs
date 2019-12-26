using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SipraişUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int Id;
        
        userDal _userDal = new userDal();
        userAccountDal _userAccountDal = new userAccountDal();
        shopDal _shopDal = new shopDal();
        shopAccountDal _shopAccountDal = new shopAccountDal();
        


        private void ButonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButonKullaniciGiris_Click(object sender, EventArgs e)
        {

            if (_userAccountDal.VerifyUser(txtKAdi.Text,txtSifre.Text))
            {
                Id=_userDal.GetUserId(txtKAdi.Text);
                KullaniciAnasayfa ka = new KullaniciAnasayfa();
                ka.Show();
                this.Visible = false;


            }
            else
            {


                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }

        }

        private void ButonMagazaGiris_Click(object sender, EventArgs e)
        {

            if (_shopAccountDal.VerifyShop(txtKAdi.Text,txtSifre.Text))
            {
                Id = _shopDal.GetShopId(txtKAdi.Text);
                MagazaAnasayfa ma = new MagazaAnasayfa();
                ma.Show();
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }

        }

        private void LabelKayitOl_Click(object sender, EventArgs e)
        {
            KayıtOl k = new KayıtOl();
            k.Show();
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
    }
}
