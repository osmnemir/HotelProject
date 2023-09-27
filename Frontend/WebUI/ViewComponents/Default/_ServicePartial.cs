using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WebUI.DTOs.RoomDto;
using WebUI.DTOs.ServiceDto;

namespace WebUI.ViewComponents.Default
{
    public class _ServicePartial:ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public _ServicePartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync() // default olarak adlandırdığı için ınvoke adını verdik
        {
            var client = _httpClientFactory.CreateClient();// İSTEMCİ CLİENT OLUŞTURUR
            var responseMessage = await client.GetAsync("http://localhost:5000/api/Service");//ADRESE İSTEKTE BULUNUR
            if (responseMessage.IsSuccessStatusCode)// BAŞARILIYSA (200) 
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();// GELEN VERİ DEĞİŞKENE ATANDI
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);// DEĞİŞEN VERİYİ TABLOYA GÖSTERMEK İÇİN FORMATI DEĞİŞTİ
                return View(values);
            }

            return View();  
        }
    }
}
