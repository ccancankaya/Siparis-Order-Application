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
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }

        userDal _userDal = new userDal();
        userAccountDal _userAccountDal = new userAccountDal();
        OrderContext _context = new OrderContext();

        private void KayıtOl_TextChanged(object sender, EventArgs e)
        {
            buttonKayıtOl.Enabled = true;
        }

        private void ButtonKayıtOl_Click(object sender, EventArgs e)
        {
            try
            {
                _userDal.Add(new User
                {
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    Address = txtAddress.Text,
                    City = txtCity.Text,
                    Tel = long.Parse(txtNo.Text),
                    Email = txtEmail.Text

                });
                _userAccountDal.Add(new UserAccount
                {
                    UserId = _context.Users.Max(u => u.UserId),
                    UserName = txtUname.Text,
                    Password = txtPass.Text

                });
                MessageBox.Show("Kayıt yapılmıştır.");

                Form1 frm = new Form1();
                frm.Show();
                this.Hide();

            }
            catch (Exception)
            {

                MessageBox.Show("Tüm alanlar dolu olmalıdır!");
            }

           

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
