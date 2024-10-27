using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace E_ticElbise.Controllers
{
    public class AdminController : Controller
    {
        public async Task<IActionResult> AdminIndexAsync()
        {
            string api = "965656d9f9a79bead2b1a83a23083a59";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v1 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "b7f6072d1dmsh7988d683fe44852p175bf1jsn8350fcb9621a" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ViewBag.UsdToTry = body;
                var json = JObject.Parse(body);
                var exchangeRate = json["result"].ToString();

                ViewBag.UsdToTry = exchangeRate;
            }

            return View();
        }
    }
}
