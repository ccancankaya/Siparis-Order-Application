using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipraişUygulaması
{
    class invoiceDal
    {
        public void Add(Invoice ınvoice)
        {
            using (OrderContext context=new OrderContext())
            {
                context.Invoices.Add(ınvoice);
                context.SaveChanges();
            }
        }

        public List<Invoice> GetAll()
        {
            using (OrderContext context=new OrderContext())
            {
                return context.Invoices.ToList();
            }
        }


    }
}
