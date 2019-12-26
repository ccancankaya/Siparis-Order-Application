using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipraişUygulaması
{
    class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Category { get; set; }
        public int ShopId { get; set; }
        [DataType(DataType.Currency,ErrorMessage ="Lütfen geçerli bir değer girin!")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public double Price { get; set; }




    }
}
