using System.ComponentModel.DataAnnotations;

namespace WebUI.DTOs.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Kullanıcı adı giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre giriniz.")]
        public string Password { get; set; }
    }
}
