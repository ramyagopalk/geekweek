using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accolite.GeekWeek.Voting.Controllers
{
    public class VotingDashboardController : Controller
    {
        //
        // GET: /VotingDashboard/

        public ActionResult Landing()
        {
            return View();
        }

    }
}
