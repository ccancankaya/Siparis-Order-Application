using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipraişUygulaması
{
     class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        public int UserId { get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]

        public string Surname { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="Lütfen geçerli bir email giriniz!")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]

        public string Address { get; set; }
        [DataType(DataType.PhoneNumber,ErrorMessage ="Lütfen telefon numaranızı kontrol ediniz!")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]

        public long Tel { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]

        public string City { get; set; }
   
    }
}
