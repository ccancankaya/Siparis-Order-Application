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
    public partial class SiparisGecmisi : Form
    {
        public SiparisGecmisi()
        {
            InitializeComponent();
        }

        orderDal _orderDal = new orderDal();

        int uid = Form1.Id;


        public void LoadOrders()
        {
            dataGridView1.DataSource= _orderDal.GetAll().Where(o => o.UserId == uid).ToList();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns[0].HeaderText = "Sipariş Numarası";
            this.dataGridView1.Columns[1].HeaderText = "Mağaza ıd";
            this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].HeaderText = "Ürün adı";
            this.dataGridView1.Columns[4].HeaderText = "Adet";
            this.dataGridView1.Columns[5].HeaderText = "Tutar";
            this.dataGridView1.Columns[6].HeaderText = "Tarih";
            this.dataGridView1.Columns[7].HeaderText = "Saat";
        }
        private void SiparisGecmisi_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void textboxProductName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxProductName.Text))
            {
                LoadOrders();
            }
            else
            {
               dataGridView1.DataSource= _orderDal.GetAll().Where(o => o.UserId == uid && o.ProductName.ToLower().Contains(textboxProductName.Text.ToLower())).ToList();
                this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridView1.Columns[0].HeaderText = "Sipariş Numarası";
                this.dataGridView1.Columns[1].HeaderText = "Mağaza ıd";
                this.dataGridView1.Columns[2].Visible = false;
                this.dataGridView1.Columns[3].HeaderText = "Ürün adı";
                this.dataGridView1.Columns[4].HeaderText = "Adet";
                this.dataGridView1.Columns[5].HeaderText = "Tutar";
                this.dataGridView1.Columns[6].HeaderText = "Tarih";
                this.dataGridView1.Columns[7].HeaderText = "Saat";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
