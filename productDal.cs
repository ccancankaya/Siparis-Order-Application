using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipraişUygulaması
{
    class productDal
    {
        shopDal _shopDal = new shopDal();
        
        public List<Product> GetAll()
        {
            using (OrderContext context=new OrderContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetById(int sid)
        {
            using (OrderContext context = new OrderContext())
            {
                return context.Products.Where(p => p.ShopId == sid).ToList();
            }
        }

        public Product GetByName(string name)
        {
            using (OrderContext context=new OrderContext())
            {
                return context.Products.SingleOrDefault(p => p.Name == name);
            }
        }

        public List<Product> GetByCategory(int sid,string category)
        {
            using (OrderContext context=new OrderContext())
            {
                return context.Products.Where(p=>p.ShopId==sid&&p.Category == category).ToList();
            }
        }
       
        public List<string> GetCategories()
        {
            using (OrderContext context=new OrderContext())
            {
                return context.Products.Select(p=>p.Category).ToList();
            }
        }
        public void Add(Product product)
        {
            using (OrderContext context=new OrderContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        
        public void Update(Product product)
        {
            using (OrderContext context=new OrderContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (OrderContext context=new OrderContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }


    }
}
