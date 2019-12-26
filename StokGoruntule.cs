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
    public partial class StokGoruntule : Form
    {
        public StokGoruntule()
        {
            InitializeComponent();
        }

        int sid = Form1.Id;
        productDal _productDal = new productDal();

     
        private void StokGoruntule_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productDal.GetById(sid);
        }

        private void SearchProduct(string key)
        {
            dataGridView1.DataSource = _productDal.GetAll().Where(p => p.Name.ToLower().Contains(key.ToLower())&&p.ShopId==sid).ToList();
        }

        private void TextboxProductName_TextChanged(object sender, EventArgs e)
        {
            var key = textboxProductName.Text;
            SearchProduct(key);
        }
    }
}
