using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipraişUygulaması
{
    class orderDal
    {
        public List<Order> GetAll()
        {
            using (OrderContext context=new OrderContext())
            {
                return context.Orders.ToList();
            }
        }

        public string GetUserName(int id)
        {
            using (OrderContext context=new OrderContext())
            {
                var name = (from order in context.Orders
                            join user in context.Users on order.OrderId
                            equals user.UserId
                            where order.UserId == id
                            select user.Name).FirstOrDefault();
                return name;
            }
        }

        public string GetShopName(int id)
        {
            using (OrderContext context=new OrderContext())
            {
                var sname = (from order in context.Orders
                             join shop in context.Shops on order.ShopId
                             equals shop.ShopId
                             where order.ShopId == id
                             select shop.Name).FirstOrDefault();
                return sname;
            }
        }

        public void Add(Order order)
        {
            using (OrderContext context=new OrderContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        public void Delete(Order order)
        {
            using (OrderContext context=new OrderContext())
            {
                var entity = context.Entry(order);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
