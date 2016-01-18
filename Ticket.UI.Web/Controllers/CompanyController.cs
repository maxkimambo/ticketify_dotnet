// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompanyController.cs" company="">
//   
// </copyright>
// <summary>
//   The company controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


namespace Ticket.UI.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Web.Mvc;
    using Ticket.Domain;
    using Ticket.Interfaces.Business;
    using Ticket.UI.Web.Models;
    using Ticket.UI.Web.ViewModels;

    /// <summary>
    /// The company controller.
    /// </summary>
    public class CompanyController : TicketControllerBase
    {

        /// <summary>
        /// The cs.
        /// </summary>
        private readonly ICompanyService cs;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyController"/> class.
        /// </summary>
        /// <param name="cs">
        /// The cs.
        /// </param>
        public CompanyController(ICompanyService cs)
        {
            this.cs = cs;
        }


        /// <summary>
        /// The register.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Register()
        {
            var company = new Company();

            return View(company);
        }

        /// <summary>
        /// The register.
        /// </summary>
        /// <param name="company">
        /// The company.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        [HttpPost]
        public ActionResult Register(Company company)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(company);
            //}

            cs.CreateCompany(company);

            return View(company);
        }

        [HttpGet]
        public ActionResult Setup(int id)
        {
            // fetch the company 
            var company = cs.GetCompanyById(id);
            var busses = cs.GetBusses(id);
            var routes = cs.GetListOfRoutes(id);

            if (company == null)
            {
                ModelState.AddModelError("notfound", "Company not found");
            }

            var setupVm = new CompanySetupViewModel();
            setupVm.Company = company;
            setupVm.Busses = busses;
            setupVm.Routes = routes;

            return View(setupVm);
        }

        [HttpPost]
        public ActionResult UpdateCompanyInfo(Company company)
        {
            var badFields = new StringBuilder();
            //if (!ModelState.IsValid)
            //{
            //    foreach (var k in this.ModelState.Keys.Where(k => !this.ModelState.IsValidField(k)))
            //    {
            //        badFields.Append(k);
            //        badFields.Append(" ");
            //    }

            //    return this.SendRequestResult(string.Format("Please correct the errors in {0} and submit again", badFields.ToString()), RequestResultType.Warning);
            //}

            try
            {
                //this.cs.EditCompany(company);
                return SendJsonRequestResult("Data saved", true, null);
            }
            catch (Exception ex)
            {
                return SendJsonRequestResult(ex.Message, false, null);
            }

        }

        [HttpPost]
        public ActionResult AddBus(int id, Bus bus)
        {
            var company = cs.GetCompanyById(id);
            cs.AddBus(company, bus);

            return SendJsonRequestResult("Bus created", true, null);
        }

        [HttpDelete]
        public ActionResult RemoveBus(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult UpdateBusses(int id, Bus bus)
        {

            return SendRequestResult("Data saved", RequestResultType.Success);
        }

        //public ActionResult CreateBus(int id)
        //{
        //    return this.PartialView("_BussesTab")
        //}

        [HttpPost]
        public ActionResult Payment(int id, Company company)
        {

            return SendRequestResult("Data saved", RequestResultType.Success);
        }

        [HttpPost]
        public ActionResult EditRoute(int id, Location start, Location destination)
        {
            var routes = cs.GetListOfRoutes(id).ToList();

            foreach (var route in routes)
            {
                if (route.Id == id)
                {
                    route.Start = start;
                    route.Destination = destination;
                }
            }

            return PartialView("_RouteTable", routes);
        }

        [HttpGet]
        public ActionResult Routes(int id)
        {
            var routes = cs.GetListOfRoutes(id).Where(r => r.Id == id);
            return base.ToJson(routes);
        }

        [HttpPost]
        public ActionResult DeleteRoute(int id)
        {
            // do the route deletion here 


            // return a fresh view with available routes. 
            return GetRoutesForCompany(id);
        }


        [HttpGet]
        public ActionResult GetRoutesForCompany(int id)
        {
            var routes = cs.GetListOfRoutes(id);

            return PartialView("_RouteTable", routes);
        }

        [HttpGet]
        public ActionResult GetBussesForCompany(int id)
        {
            var busses = cs.GetBusses(id);

            return PartialView("_BussesTab", busses);
        }


    }
}