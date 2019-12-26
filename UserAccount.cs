using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipraişUygulaması
{
    class UserAccount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public int UserId { get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz!")]
        
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="Şifre 6 karakterden az olamaz"),MaxLength(10,ErrorMessage ="Şifre 10 karakterden fazla olamaz")]
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        public string Password { get; set; }



    }
}
