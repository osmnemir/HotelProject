namespace WebUI.DTOs.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomCoverImahge { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string BedCount { get; set; }
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Decsription { get; set; }
    }
}
