using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AutofacWebApiSample_.Controllers
{
    public class GreetingsService : IGreetingsService
    {
        public string GetGreetings()
        {
            return "Hello at " + DateTime.Now.ToShortTimeString();
        }
    }
}
