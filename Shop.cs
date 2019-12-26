using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipraişUygulaması
{
    class Shop
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShopId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string City { get; set; }
        [DataType(DataType.PhoneNumber, ErrorMessage = "Lütfen geçerli bir telefon nuamarsı girin!")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public long Tel { get; set; }

        public DateTime CloseTime { get; set; }
        public bool IsSentry { get; set; }
    }
}
