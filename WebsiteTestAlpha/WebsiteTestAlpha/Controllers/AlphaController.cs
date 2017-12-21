using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteTestAlpha.Models;

namespace WebsiteTestAlpha.Controllers
{
    public class AlphaController : Controller
    {
        // GET: Alpha
        public ActionResult Index()
        {
            AlphaModel alphys = new AlphaModel();

            alphys.CountUp = 0;

            alphys.UserInput = 0;

            alphys.ExtraMessage = "test";

            return View("Index", alphys);
        }

        public ActionResult RepeatProcedure(AlphaModel a)
        {
            AlphaModel alphys = new AlphaModel();

            alphys.CountUp = a.CountUp + 1;

            alphys.UserInput = a.UserInput;

            alphys.ExtraMessage = a.ExtraMessage;

            return View("Index", alphys);
            //a.CountUp = a.CountUp + 1 ;

            //return View("Index", a);
        }
    }
}