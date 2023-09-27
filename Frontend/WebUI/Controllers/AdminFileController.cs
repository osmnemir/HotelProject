using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class AdminFileController : Controller // IMAGE İÇİN
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Index(IFormFile file)
        {
            var stream = new MemoryStream(); // dosya akışı olulşturudu
            await file.CopyToAsync(stream);  // dosyayı kopyaladı
            var bytes = stream.ToArray(); // dosyayı byte olarak tutuyor

            ByteArrayContent byteArrayContent = new ByteArrayContent(bytes);// byte dizisi yaptık
            byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType); // dosya içerik türü yolladık
            MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();// nesne örneği aldık
            multipartFormDataContent.Add(byteArrayContent, "file", file.FileName);  // içine file filename ekliyoruz.
            var httpclient = new HttpClient();
            await httpclient.PostAsync("http://localhost:5000/api/FileImage", multipartFormDataContent); // multipartFormDataContent bununla adrese gidilecek



            return View();
        }

    }
}
