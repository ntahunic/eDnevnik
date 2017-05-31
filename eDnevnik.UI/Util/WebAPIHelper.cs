using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace eDnevnik.UI.Util
{
    public class WebAPIHelper
    {
        public HttpClient client { get; set; }
        public string route { get; set; }

        public WebAPIHelper(string route)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64211");
            this.route = route;
        }
        public WebAPIHelper(string route, string uri)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            this.route = route;
        }

        public HttpResponseMessage GetResponse()
        {
            return client.GetAsync(route).Result;
        }
        //api/Nastavnici/{username}
        public HttpResponseMessage GetResponse(string parametar)
        {
            return client.GetAsync(route +"/"+ parametar).Result;
        }


        public HttpResponseMessage PostResponse(object obj)
        {
            return client.PostAsJsonAsync(route, obj).Result;
        }
    }
}
