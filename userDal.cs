using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipraişUygulaması
{
    class userDal
    {
        int ıd;

        public int GetUserId(string username)
        {
            using (OrderContext context = new OrderContext())
            {
                var Id = (from user in context.Users
                          join uname in context.UserAccounts on user.UserId
                          equals uname.UserId
                          where uname.UserName == username
                          select user.UserId).SingleOrDefault();
                return Id;
            }
        }

        public List<User> GetAll()
        {
            using (OrderContext context = new OrderContext())
            {
                return context.Users.ToList();
            }
        }


        public string GetUserAddress()
        {
            using (OrderContext context = new OrderContext())
            {
                var user = context.Users.Where(u => u.UserId == ıd).FirstOrDefault();
                if (user != null)
                {
                    return user.Address;
                }
                else
                {
                    return null;
                }
            }
        }

        public void Add(User user)
        {
            using (OrderContext context = new OrderContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void Update(User user)
        {
            using (OrderContext context = new OrderContext())
            {
                var entity = context.Entry(user);
                entity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }

    }
}
