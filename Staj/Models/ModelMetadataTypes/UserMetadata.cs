using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Staj.Models.ModelMetadataTypes
{
    public class UserMetadata
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="İsim'i boş geçemezsiniz!!!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyisim'i boş geçemezsiniz!!!")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Şifre alanı boş geçilmez")]
        [StringLength(25, ErrorMessage = "Şifre 5 ile 20 karakter arası olmalıdır!!!", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre alanı boş geçilmez")]
        [StringLength(25, ErrorMessage = "Şifre 5 ile 20 karakter arası olmalıdır!!!", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }
        [Required(ErrorMessage ="Email Giremelisiniz!!!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
