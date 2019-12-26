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
    public partial class MagazaAnasayfa : Form
    {
        TabPage tbg = null;
        public MagazaAnasayfa()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            giris.Show();
            this.Visible = false;
        }

        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle r = tabControl1.GetTabRect(tabControl1.TabPages.Count - 1);
            RectangleF rf = new RectangleF(r.X + r.Width, r.Y - 5, tabControl1.Width - (r.X + r.Width), r.Height + 5);
            Brush b = new SolidBrush(ColorTranslator.FromHtml("#0047A0"));
            e.Graphics.FillRectangle(b, rf);
        }

        private void ButonUrunEkle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["UrunEkle"] == null)
            {
                UrunEkle formUrunEkleme = new UrunEkle();
                tbg = new TabPage(Text = "Ürün Ekle");
                tbg.BorderStyle = BorderStyle.Fixed3D;
                tabControl1.TabPages.Add(tbg);

                formUrunEkleme.TopLevel = false;
                formUrunEkleme.Parent = tbg;
                formUrunEkleme.Show();
                formUrunEkleme.Dock = DockStyle.Fill;
                formUrunEkleme.Show();
                tabControl1.SelectedTab = tbg;
            }
        }

        private void ButonStokGoruntule_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["StokGoruntule"] == null)
            {
                StokGoruntule formStokGoruntuleme = new StokGoruntule();
                tbg = new TabPage(Text = "Stok Görüntüle");
                tbg.BorderStyle = BorderStyle.Fixed3D;
                tabControl1.TabPages.Add(tbg);

                formStokGoruntuleme.TopLevel = false;
                formStokGoruntuleme.Parent = tbg;
                formStokGoruntuleme.Show();
                formStokGoruntuleme.Dock = DockStyle.Fill;
                formStokGoruntuleme.Show();
                tabControl1.SelectedTab = tbg;
            }
        }

        private void ButonRaporAl_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RaporAl"] == null)
            {
                RaporAl formRaporAlma = new RaporAl();
                tbg = new TabPage(Text = "Rapor Al");
                tbg.BorderStyle = BorderStyle.Fixed3D;
                tabControl1.TabPages.Add(tbg);

                formRaporAlma.TopLevel = false;
                formRaporAlma.Parent = tbg;
                formRaporAlma.Show();
                formRaporAlma.Dock = DockStyle.Fill;
                formRaporAlma.Show();
                tabControl1.SelectedTab = tbg;
            }
        }

        private void ButonGelenSiparis_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["GelenSiparis"] == null)
            {
                GelenSiparis formGelenSiparisler = new GelenSiparis();
                tbg = new TabPage(Text = "Gelen Siparişler");
                tbg.BorderStyle = BorderStyle.Fixed3D;
                tabControl1.TabPages.Add(tbg);

                formGelenSiparisler.TopLevel = false;
                formGelenSiparisler.Parent = tbg;
                formGelenSiparisler.Show();
                formGelenSiparisler.Dock = DockStyle.Fill;
                formGelenSiparisler.Show();
                tabControl1.SelectedTab = tbg;
            }
        }

        private void MagazaAnasayfa_Load(object sender, EventArgs e)
        {
            this.tabControl1.DrawItem += new DrawItemEventHandler(TabControl1_DrawItem);
        }

        shopDal _shopDal = new shopDal();
        int sid = Form1.Id;
        private void button1_Click(object sender, EventArgs e)
        {
            var shop = _shopDal.GetAll().FirstOrDefault(s => s.ShopId == sid);
            _shopDal.Update(new Shop
            {
                ShopId=sid,
                Name=shop.Name,
                Address=shop.Address,
                City=shop.City,
                Tel=shop.Tel,
                CloseTime=shop.CloseTime,
                IsSentry=true
            });

            MessageBox.Show("Nöbettçi olundu");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
