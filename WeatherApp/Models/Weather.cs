using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WeatherApp.Models
{
    class Weather
    {
        public Object getWeatherForcast()
        {
            string appid = "82fe51335ada2a172bf15266e5ffba46";
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Cleveland&APPID=" + appid + "&units=imperial";
            //synchronous client.
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }

    }
}
