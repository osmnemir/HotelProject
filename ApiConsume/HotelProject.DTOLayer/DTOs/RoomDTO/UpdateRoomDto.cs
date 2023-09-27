using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DTOLayer.DTOs.RoomDTO
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Lütfen oda no giriniz")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen oda görseli giriniz")]
        public string RoomCoverImahge { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat no giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen başlık giriniz")]
        [StringLength(100,ErrorMessage ="max 100 karekter")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısı giriniz")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayısı giriniz")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen oda açıklaması giriniz")]
        public string Decsription { get; set; }
    }
}
