﻿using HotelProject.EntityLayer.Concrete;

namespace WebUI.DTOs.AppUserDto
{
    public class ResultAppUserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }

        public string WorkDepartman { get; set; }
        public int WorkLocationID { get; set; }
        public WorkLocation WorkLocation { get; set; }
    }
}
