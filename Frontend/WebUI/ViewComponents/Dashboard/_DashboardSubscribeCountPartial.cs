using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using WebUI.DTOs.FollowersDto;
using Newtonsoft.Json;
using System.Linq;

namespace WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/osmn.emr"),
                Headers =
    {
        { "X-RapidAPI-Key", "81c35140b7mshf513ad093a65b09p16e7e6jsn56d35fb88ee6" },
        { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto resultInstagramFollowersDto =JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.v1 = resultInstagramFollowersDto.followers;
                ViewBag.v2 = resultInstagramFollowersDto.following;
                return View(resultInstagramFollowersDto);
            }
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fosman-emir-4a8195212%2F"),
                Headers =
    {
        { "X-RapidAPI-Key", "81c35140b7mshf513ad093a65b09p16e7e6jsn56d35fb88ee6" },
        { "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ResultLınkedlnFollowersDto resultLınkedlnFollowersDto = JsonConvert.DeserializeObject<ResultLınkedlnFollowersDto>(body2);
                ViewBag.v3 = resultLınkedlnFollowersDto.data.followers_count;
                ViewBag.v4 = resultLınkedlnFollowersDto.data.connections_count;
                return View(resultLınkedlnFollowersDto);
            }

        }
    
    }
}
