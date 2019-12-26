using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipraişUygulaması
{
    class shopAccountDal
    {
        int ıd;

        public bool VerifyShop(string uname,string pass)
        {
            using (OrderContext context = new OrderContext())
            {
                var user= context.ShopAccouts.Where(s => s.UserName == uname && s.Password == pass).FirstOrDefault();

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


        public List<ShopAccout> GetShopAccoutsInfo()
        {
            using (OrderContext context = new OrderContext())
            {
                return context.ShopAccouts.Where(s => s.ShopId == ıd).ToList();
            }
        }

        public void Add(ShopAccout shopAccout)
        {
            using (OrderContext context= new OrderContext())
            {
                context.ShopAccouts.Add(shopAccout);
                context.SaveChanges();
            }
        }

        public void Update(ShopAccout shopAccout)
        {
            using (OrderContext context=new OrderContext())
            {
                var entity = context.Entry(shopAccout);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }


    }
}
