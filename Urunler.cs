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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        int id = SiparisVer.id;
        public static int pid;
        public static int adet;
        productDal _productDal = new productDal();

        void ProductLoad()
        {
            dataGridView1.DataSource = _productDal.GetById(id).ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Ürün adı";
            dataGridView1.Columns[2].HeaderText = "Kategori";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Fiyat";
        }
        void ProductLoadByName(int sid,string key)
        {
            dataGridView1.DataSource = _productDal.GetAll().Where(p => p.Name.ToLower().Contains(key.ToLower())&&p.ShopId==sid).ToList();

        }

        void ProductLoadByCategory(int id,string category)
        {
            dataGridView1.DataSource = _productDal.GetByCategory(id,category);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Ürün adı";
            dataGridView1.Columns[2].HeaderText = "Kategori";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Fiyat";
        }

        private void Urunler_Load(object sender, EventArgs e)
        {

            ProductLoad();
            comboBox1.DataSource = _productDal.GetCategories();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var key = textBox1.Text;
           
            if (String.IsNullOrEmpty(key))
            {
                ProductLoad();
            }
            else
            {
                ProductLoadByName(id,key);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductLoadByCategory(id,comboBox1.SelectedItem.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductLoad();
        }

        private void sepeteEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            Sepet sepet = new Sepet();
            sepet.Show();
            adet = Convert.ToInt32(txtAdet.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            
        }
    }
}
