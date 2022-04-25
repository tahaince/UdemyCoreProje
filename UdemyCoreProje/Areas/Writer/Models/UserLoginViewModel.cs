using System.ComponentModel.DataAnnotations;

namespace UdemyCoreProje.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="Lütfen bu alanı doldurunuz")]
        public string UserName { get; set; }


        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz")]
        public string Password { get; set; }

    }
}
