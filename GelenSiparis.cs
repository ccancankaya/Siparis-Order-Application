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
    public partial class GelenSiparis : Form
    {
        public GelenSiparis()
        {
            InitializeComponent();
        }

        orderDal _orderDal = new orderDal();
        invoiceDal _invoiceDal = new invoiceDal();
        int sid = Form1.Id;
        void LoadOrders()
        {
            dataGridView1.DataSource = _orderDal.GetAll().Where(o=>o.ShopId==sid).ToList();
        }
        private void GelenSiparis_Load(object sender, EventArgs e)
        {
            LoadOrders();
            int id = _orderDal.GetAll().Select(o => o.UserId).FirstOrDefault();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns[0].HeaderText = "Sipariş Numarası";
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[2].HeaderText = "Kullanıcı ıd";
            this.dataGridView1.Columns[3].HeaderText = "Ürün adı";
            this.dataGridView1.Columns[4].HeaderText = "Adet";
            this.dataGridView1.Columns[5].HeaderText = "Tutar";
            this.dataGridView1.Columns[6].HeaderText = "Tarih";
            this.dataGridView1.Columns[7].HeaderText = "Saat";
        }

        private void SearchOrder(int id)
        {
            dataGridView1.DataSource = _orderDal.GetAll().SingleOrDefault(o => o.OrderId == id);

        }


        private void TextboxProductName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxProductName.Text))
            {
                LoadOrders();
            }
            else
            {
                SearchOrder(int.Parse(textboxProductName.Text));

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _invoiceDal.Add(new Invoice
            {
                AddedTime=DateTime.Now,
                OrderId=Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Siparişi onayladınız");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            _orderDal.Delete(new Order
            {
                OrderId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString())
            });
            LoadOrders();
            MessageBox.Show("Seçilen sipariş iptal edildi!");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }


}
