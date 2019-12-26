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
    public partial class KullanıcıBilgiGuncelle : Form
    {
     

        public KullanıcıBilgiGuncelle()
        {
            InitializeComponent();
        }

        int Id=Form1.Id;
        userDal _userDal = new userDal();
        userAccountDal _userAccountDal = new userAccountDal();
        
        void LoadUserInfo()
        {
            var user = _userDal.GetAll().Where(u => u.UserId == Id).FirstOrDefault();
            var userAccount = _userAccountDal.GetUAccountInfo();
            txtName.Text = user.Name;
            txtSurname.Text = user.Surname;
            txtUname.Text = userAccount.UserName;
            TxtPass.Text = userAccount.Password;
            txtAddress.Text = user.Address;
            txtCity.Text = user.City;
            txtNo.Text = user.Tel.ToString();
            txtEmail.Text = user.Email;
        }
        

        private void KullanıcıBilgiGuncelle_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void ButtonKayıtOl_Click(object sender, EventArgs e)
        {
            int id = _userAccountDal.GetUAccountInfo().Id;
            _userDal.Update(new User
            {
                UserId=Id,
                Name=txtName.Text,
                Surname=txtSurname.Text,
                Address=txtAddress.Text,
                City=txtCity.Text,
                Tel=long.Parse(txtNo.Text),
                Email=txtEmail.Text
            });

            _userAccountDal.Update(new UserAccount
            {
                Id=id,
                UserId=Id,
                UserName=txtUname.Text,
                Password=TxtPass.Text
            });

            MessageBox.Show("Bilgileriniz güncellenmiştir.");

        }
    }
}
