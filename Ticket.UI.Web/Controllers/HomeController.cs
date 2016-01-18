using System.Web.Mvc;

namespace Ticket.UI.Web.Controllers
{
    using Ticket.Interfaces.Business;

    public class HomeController : Controller
    {
        private readonly ICompanyService companyService;

        private readonly ITripScheduleService scheduleService;

        public HomeController(ICompanyService companyService, ITripScheduleService scheduleService)
        {
            this.companyService = companyService;
            this.scheduleService = scheduleService;
        }

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return this.View();
        }

        public JsonResult GetScheduledTrips()
        {
            var schedule = this.scheduleService.GetFeaturedDestinationsSchedule();

            return this.Json(schedule, JsonRequestBehavior.AllowGet);
        }
    }
}