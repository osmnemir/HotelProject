using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DTOLayer.DTOs.RoomDTO
{
    public class RoomAddDto
    {
        [Required(ErrorMessage ="Lütfen oda no giriniz")]
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomCoverImahge { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat no giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen başlık giriniz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısı giriniz")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayısı giriniz")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Decsription { get; set; } 
    }
}
