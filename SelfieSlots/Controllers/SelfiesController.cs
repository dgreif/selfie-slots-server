using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Infrastructure;
using SelfieSlots.Models;
using SelfieSlots.Signalr;

namespace SelfieSlots.Controllers
{
    public class SelfiesController : ApiController
    {
        // POST api/values
        public void Post(Selfie selfie)
        {
            var context = GlobalHost.ConnectionManager.GetConnectionContext<RtConnection>();
            context.Connection.Broadcast(selfie);
        }
    }
}
