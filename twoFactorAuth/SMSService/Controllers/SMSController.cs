using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSService.Controllers
{
    using System.Web.Http;

    public class SmsController : ApiController
    {

        public void Post([FromBody]string phoneNumber, string password)
        {

        }

    }
}