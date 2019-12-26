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
    public partial class Sepet : Form
    {
        public Sepet()
        {
            InitializeComponent();
        }
        int pid = Urunler.pid;
        productDal _productDal = new productDal();
        orderDal _orderDal = new orderDal();
        int uid = Form1.Id;
        int adet;

        void LoadProducts()
        {
            dataGridView1.DataSource = _productDal.GetById(pid).ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Ürün adı";
            dataGridView1.Columns[2].HeaderText = "Kategori";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Fiyat";
        }

        private void Sepet_Load(object sender, EventArgs e)
        {
            
            LoadProducts();
            decimal toplam = 0;
            int a = Urunler.adet;
            if (dataGridView1.RowCount > 0)
            {

                for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    toplam += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                }
            }

            label2.Text = toplam .ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adet = Urunler.adet;
            if (dataGridView1.RowCount > 0)
            {
                for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    _orderDal.Add(new Order
                    {
                        ShopId = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value),
                        UserId = uid,
                        ProductName = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                        Quantity = adet,
                        Amount = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value)*adet,
                        Date = Convert.ToDateTime(DateTime.Now.ToLongDateString()),
                        Time = Convert.ToDateTime(DateTime.Now.ToLongTimeString())
                    });
                }
                //dataGridView1.Rows.Clear();
                this.Close();
                MessageBox.Show("Siparişiniz alınmıştır.");
            }
            else
            {
                MessageBox.Show("Sepetiniz de ürün bulunamadı");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
