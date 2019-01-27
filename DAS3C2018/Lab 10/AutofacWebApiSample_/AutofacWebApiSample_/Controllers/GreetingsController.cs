using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AutofacWebApiSample_.Controllers
{
    public class GreetingsController : ApiController
    {

        IGreetingsService service;

        //public GreetingsController()
        //{
        //    service = new GreetingsService();
        //}

        //public GreetingsController(IGreetingsService service)
        //{
        //    this.service = service;
        //}

        public IGreetingsService GreetingsService { get; set; }

        public string Get()
        {
            return service.GetGreetings();
            //return "Hello World!";
        }
    }
}
