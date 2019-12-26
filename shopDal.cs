using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipraişUygulaması
{
    class shopDal
    {
        int ıd;

        public List<Shop> GetAll()
        {
            using (OrderContext context = new OrderContext())
            {
                return context.Shops.ToList();
            }
        }

        public int GetShopId(string Uname)
        {
            using (OrderContext context= new OrderContext())
            {
                var Id = (from shop in context.Shops
                          join uname in context.ShopAccouts on shop.ShopId
                          equals uname.ShopId
                          where uname.UserName == Uname
                          select shop.ShopId).SingleOrDefault();
                return Id;
            }
        }

        public string GetShopNameById(int id)
        {
            using (OrderContext context=new OrderContext())
            {
                return context.Shops.FirstOrDefault(s => s.ShopId == id).Name;
            }
        }

        public void Add(Shop shop)
        {
            using (OrderContext context=new OrderContext())
            {
                context.Shops.Add(shop);
                context.SaveChanges();
            }
        }

        public void Update(Shop shop)
        {
            using (OrderContext context = new OrderContext())
            {
                var entity = context.Entry(shop);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }



    }
}
