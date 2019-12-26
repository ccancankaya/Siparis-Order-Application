using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipraişUygulaması
{
    class userAccountDal
    {
        int ıd=Form1.Id;

        public bool VerifyUser(string uname,string pass)
        {
            using (OrderContext context= new OrderContext())
            {
                var user = context.UserAccounts.Where(u => u.UserName == uname && u.Password == pass).FirstOrDefault();
                if (user!=null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public UserAccount GetUAccountInfo()
        {
            using (OrderContext context = new OrderContext())
            {
                return context.UserAccounts.Where(u => u.UserId == ıd).FirstOrDefault();
            }
        }

        public void Add(UserAccount userAccount)
        {
            using (OrderContext context=new OrderContext())
            {
                context.UserAccounts.Add(userAccount);
                context.SaveChanges();
            }
        }

        public void Update(UserAccount userAccount)
        {
            using (OrderContext context = new OrderContext())
            {
                var entity = context.Entry(userAccount);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
