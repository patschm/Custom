using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using WepZeurver.Services;

namespace WepZeurver.Controllers
{
    [Route("meting")]
    public class MeetController : ControllerBase
    {
       private static List<MeetResult> metingen = new List<MeetResult>();
        private IHubContext<ZeurService> hubby;

        public MeetController(IHubContext<ZeurService> svc)
        {
            hubby = svc;
        }
        static MeetController()
        {
            metingen.Add(new MeetResult
            {
                SerialNumber = "Serie 1",
                TypeNummer = "Type 1",
                Resultaten = new string[] { "Resultaat 1", "Resultaat 2" }
            });
            metingen.Add(new MeetResult
            {
                SerialNumber = "Serie 2",
                TypeNummer = "Type 2",
                Resultaten = new string[] { "Resultaat 3", "Resultaat 4" }
            });
        }

        [Route("results")]
        public IActionResult Metingen()
        {
            Console.WriteLine("Results");
            return Ok(metingen);
        }

        [Route("add")]
        [HttpPost]
       // [Authorize]
        public IActionResult AddMeting([FromBody]MeetResult meting)
        {
            hubby.Clients.All.SendAsync("toeter", "Nieuwe Data");
            metingen.Add(meting);
            return Created("Blabla", 1);
        }
    }
}
