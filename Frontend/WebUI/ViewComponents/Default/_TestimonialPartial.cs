using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WebUI.DTOs.ServiceDto;
using WebUI.DTOs.TestimonialDto;
using WebUI.Models.Testimonial;

namespace WebUI.ViewComponents.Default
{
    public class _TestimonialPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _TestimonialPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync() // default olarak adlandırdığı için ınvoke adını verdik
        {
            var client = _httpClientFactory.CreateClient();// İSTEMCİ CLİENT OLUŞTURUR
            var responseMessage = await client.GetAsync("http://localhost:5000/api/Testimonial");//ADRESE İSTEKTE BULUNUR
            if (responseMessage.IsSuccessStatusCode)// BAŞARILIYSA (200) 
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();// GELEN VERİ DEĞİŞKENE ATANDI
                var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);// DEĞİŞEN VERİYİ TABLOYA GÖSTERMEK İÇİN FORMATI DEĞİŞTİ
                return View(values);
            }

            return View();
        }
    }
}
