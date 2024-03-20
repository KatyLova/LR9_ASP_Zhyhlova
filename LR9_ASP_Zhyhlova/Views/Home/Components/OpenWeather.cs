using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using LR9_ASP_Zhyhlova.Models;

namespace LR9_ASP_Zhyhlova.Views.Home.Components
{
    public class OpenWeather : ViewComponent
    {
        string key = "3ae2e6e687c3cc067dc49375fc94f7b8";
        public async Task<IViewComponentResult> InvokeAsync(string city)
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}&units=metric";
            using (var http = new HttpClient())
            {
                using (var response = await http.GetAsync(url))
                {
                    using (var content = response.Content)
                    {
                        var result = await content.ReadAsStringAsync();
                        ResponseWeather resp1 = JsonConvert.DeserializeObject<ResponseWeather>(result);
                        return View(resp1);
                    }
                }
            }
        }
    }
}
