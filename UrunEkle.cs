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
    public partial class UrunEkle : Form
    {
        int sıd = Form1.Id;
        public UrunEkle()
        {
            InitializeComponent();
        }

        productDal _productDal = new productDal();
       
        void Loadproducts()
        {
            dataGridView1.DataSource =  _productDal.GetById(sıd);
            dataGridView1.Columns[0].HeaderText = "Ürün numarası";
            dataGridView1.Columns[1].HeaderText = "Ürün adı";
            dataGridView1.Columns[2].HeaderText = "Kategori";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Birim fiyat";
        }

       

       

        private void ButtonAddLog_Click(object sender, EventArgs e)
        {


            _productDal.Add(new Product
            {
                Name=textBox1.Text,
                Category=textBox2.Text,
                ShopId=sıd,
                Price=Convert.ToDouble(textBox3.Text)
            });
           
            

                
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {

            Loadproducts();

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();           
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void ButtonUpdateLog_Click(object sender, EventArgs e)
        {

            _productDal.Update(new Product
            {
                ProductId= Convert.ToInt32( dataGridView1.SelectedRows[0].Cells[0].Value),
                Name=textBox1.Text,
                Category=textBox2.Text,
                ShopId=sıd,
                Price=Convert.ToDouble(textBox3.Text)
            });
            Loadproducts();

            MessageBox.Show("Ürün güncellendi");
        }

        private void ButtonDeleteLog_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product { 
                ProductId= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)
            });
            Loadproducts();
            MessageBox.Show("Ürün silindi");
        }

    }
}
