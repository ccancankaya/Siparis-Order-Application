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
    public partial class KullaniciAnasayfa : Form
    {
        TabPage tbg = null;

        public KullaniciAnasayfa()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            giris.Show();
            this.Visible = false;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle r = tabControl1.GetTabRect(tabControl1.TabPages.Count - 1);
            RectangleF rf = new RectangleF(r.X + r.Width, r.Y - 5, tabControl1.Width - (r.X + r.Width), r.Height + 5);
            Brush b = new SolidBrush(ColorTranslator.FromHtml("#0047A0"));
            e.Graphics.FillRectangle(b, rf);
        }

        private void ButonBilgilerimiGuncelle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["KullanıcıBilgiGuncelle"] == null)
            {
                KullanıcıBilgiGuncelle formBilgiGuncelle = new KullanıcıBilgiGuncelle();
                tbg = new TabPage(Text = "Bilgi Güncelleme");
                tbg.BorderStyle = BorderStyle.Fixed3D;
                tabControl1.TabPages.Add(tbg);

                formBilgiGuncelle.TopLevel = false;
                formBilgiGuncelle.Parent = tbg;
                formBilgiGuncelle.Show();
                formBilgiGuncelle.Dock = DockStyle.Fill;
                formBilgiGuncelle.Show();
                tabControl1.SelectedTab = tbg;
            }
        }

        private void ButtonSiparisVer_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SiparisVer"] == null)
            {
                SiparisVer formSiparisVer = new SiparisVer();
                tbg = new TabPage(Text = "Sipariş Ver");
                tbg.BorderStyle = BorderStyle.Fixed3D;
                tabControl1.TabPages.Add(tbg);

                formSiparisVer.TopLevel = false;
                formSiparisVer.Parent = tbg;
                formSiparisVer.Show();
                formSiparisVer.Dock = DockStyle.Fill;
                formSiparisVer.Show();
                tabControl1.SelectedTab = tbg;
            }
        }

        private void ButtonSiparisGecmisi_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["SiparisGecmisi"] == null)
            {
                SiparisGecmisi formGecmisSiparis = new SiparisGecmisi();
                tbg = new TabPage(Text = "Sipariş Geçmişi");
                tbg.BorderStyle = BorderStyle.Fixed3D;
                tabControl1.TabPages.Add(tbg);

                formGecmisSiparis.TopLevel = false;
                formGecmisSiparis.Parent = tbg;
                formGecmisSiparis.Show();
                formGecmisSiparis.Dock = DockStyle.Fill;
                formGecmisSiparis.Show();
                tabControl1.SelectedTab = tbg;
            }
        }

        private void KullaniciAnasayfa_Load(object sender, EventArgs e)
        {
            this.tabControl1.DrawItem += new DrawItemEventHandler(TabControl1_DrawItem);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Sepet"] == null)
            {
                Sepet sepetgor = new Sepet();
                tbg = new TabPage(Text = "Sipariş Geçmişi");
                tbg.BorderStyle = BorderStyle.Fixed3D;
                tabControl1.TabPages.Add(tbg);

                sepetgor.TopLevel = false;
                sepetgor.Parent = tbg;
                sepetgor.Show();
                sepetgor.Dock = DockStyle.Fill;
                sepetgor.Show();
                tabControl1.SelectedTab = tbg;
            }
        }
    }
}
