using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipraişUygulaması
{
    class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int OrderId { get; set; }
        public int ShopId { get; set; }
        public int UserId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }



    }
}
