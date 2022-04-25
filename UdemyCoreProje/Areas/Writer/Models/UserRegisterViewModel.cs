using System.ComponentModel.DataAnnotations;

namespace UdemyCoreProje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {

        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz")]
        public string ImageUrl { get; set; }



        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz")]

        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz")]
        [Compare("Password",ErrorMessage ="Şifreler aynı olmalıdır")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz")]

        public string Mail { get; set; }

    }
}
