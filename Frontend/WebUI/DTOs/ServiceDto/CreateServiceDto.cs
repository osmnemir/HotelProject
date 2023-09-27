using System.ComponentModel.DataAnnotations;

namespace WebUI.DTOs.ServiceDto
{
    public class CreateServiceDto
    {

        [Required(ErrorMessage ="Servis İkon linki giriniz.")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Servis başlığı giriniz.")]
        [StringLength(100,ErrorMessage ="max 100 karekter.")]
        public string Title { get; set; }
        public string Descrription { get; set; }
    }
}
