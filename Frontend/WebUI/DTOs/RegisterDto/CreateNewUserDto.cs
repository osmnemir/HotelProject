using System.ComponentModel.DataAnnotations;

namespace WebUI.DTOs.RegisterDto
{
    public class CreateNewUserDto
    {

        [Required(ErrorMessage = "Ad Alanı Gerekli")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad Alanı Gerekli")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı Alanı Gerekli")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mail Alanı Gerekli")]
        public string Mail { get; set; }


        [Required(ErrorMessage = "Şifre Alanı Gerekli")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Tekrar Şifre Alanı Gerekli")]
        [Compare ("Password",ErrorMessage ="Şifreler uyuşmuyor tekrar deneyiniz.")]
        public string ConfirmPassword { get; set; }
        
    }
}
