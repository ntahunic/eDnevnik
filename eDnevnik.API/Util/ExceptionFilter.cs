using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace eDnevnik.API.Util
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception is NotImplementedException)
            {
                HttpResponseMessage msg = new HttpResponseMessage()
                {
                    StatusCode = System.Net.HttpStatusCode.PaymentRequired,
                    ReasonPhrase = "Uplata obavezna!",
                    Content = new StringContent("Potrebno izvršiti uplatu!")
                };

                actionExecutedContext.Response = msg;
            }

            else
                base.OnException(actionExecutedContext);
        }
    }
}
