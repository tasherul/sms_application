using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sms.Controllers
{
    public class infoController : Controller
    {
        //
        // GET: /info/

        public ActionResult Index()
        {
            var Show = new sms.Models.information()
            {
                Name = "Piash2",
                Age = 215,
                Details = "Computer Engneer2"
            };

            List<sms.Models.information> li = new List<sms.Models.information>();
            li.Add(Show);



            
            ViewData["Data"] = Show;
            return View();
        }

    }
}
