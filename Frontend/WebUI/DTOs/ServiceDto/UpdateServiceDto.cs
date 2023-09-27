using System.ComponentModel.DataAnnotations;

namespace WebUI.DTOs.ServiceDto
{
    public class UpdateServiceDto


    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Servis İkon linki giriniz.")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Servis başlığı giriniz.")]
        [StringLength(100, ErrorMessage = "max 100 karekter.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Servis açıklaması giriniz.")]
        [StringLength(500, ErrorMessage = "max 500 karekter.")]
        public string Descrription { get; set; }
    }
}
