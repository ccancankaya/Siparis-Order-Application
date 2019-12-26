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
    public partial class SiparisVer : Form
    {
        public SiparisVer()
        {
            InitializeComponent();
        }

        shopDal _shopDal = new shopDal();
        public static int id;
          
        void ShopLoad()
        {
            flowLayoutPanel1.Controls.Clear();
            int n = _shopDal.GetAll().Count();

            for (int i = 1; i < n+1; i++)
            {

                Button btn = new Button();
                btn.Name = "btn" + _shopDal.GetShopNameById(i);
                btn.Text = _shopDal.GetShopNameById(i);
                btn.Width = 200;
                btn.Height = 200;
                btn.Margin = new Padding(20);
                btn.TabIndex = i;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += Btn_Click;

            }
            
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            id = (sender as Button).TabIndex;
            Urunler u = new Urunler();
            u.Show();
        }

        void ShopLoadByName(string sname)
        {
            flowLayoutPanel1.Controls.Clear();
            string name = _shopDal.GetAll().Where(s => s.Name == sname).Select(s => s.Name).FirstOrDefault();
            if (name==sname)
            {
                Button btn = new Button();
                btn.Name = name;
                btn.Text = name;
                btn.Width = 200;
                btn.Height = 200;
                btn.Margin = new Padding(20);
                flowLayoutPanel1.Controls.Add(btn);
            }
            else if (String.IsNullOrEmpty(txtShopname.Text))
            {
                ShopLoad();
            }
           
        }

        void ShopLoadBySentry()
        {
            flowLayoutPanel1.Controls.Clear();
            var shops = _shopDal.GetAll().Where(s => s.IsSentry == true).ToList();
            int n = shops.Count();
            for (int i = 1; i < n + 1; i++)
            {

                Button btn = new Button();
                btn.Name = "btn" + _shopDal.GetShopNameById(i);
                btn.Text = _shopDal.GetShopNameById(i);
                btn.Width = 200;
                btn.Height = 200;
                btn.Margin = new Padding(20);
                flowLayoutPanel1.Controls.Add(btn);
            }

        }

        //void ShopLoadByTime()
        //{
        //    flowLayoutPanel1.Controls.Clear();
        //    List<Shop> shops = _shopDal.GetAll().Where(s => s.CloseTime.ToLongTimeString() < DateTime.Now.ToLongTimeString()).ToList();
        //    int n = shops.Count();
        //    for (int i = 1; i < n + 1; i++)
        //    {

        //        Button btn = new Button();
        //        btn.Name = "btn" + _shopDal.GetShopNameById(i);
        //        btn.Text = _shopDal.GetShopNameById(i);
        //        btn.Width = 200;
        //        btn.Height = 200;
        //        btn.Margin = new Padding(20);
        //        flowLayoutPanel1.Controls.Add(btn);
        //    }

        //}

        private void SiparisVer_Load(object sender, EventArgs e)
        {
            ShopLoad();
        }

        private void txtShopname_TextChanged(object sender, EventArgs e)
        {
            ShopLoadByName(txtShopname.Text);
        }

        private void comboSentry_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboSentry.SelectedIndex==0)
            {
                ShopLoadBySentry();
            }
            else if(comboSentry.SelectedIndex==1)
            {
                ShopLoad();
                
            }
        }

        private void comboOpen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboOpen.SelectedIndex==0)
            {
                //ShopLoadByTime();
            }
            else
            {
                ShopLoad();
            }
        }
    }
}
