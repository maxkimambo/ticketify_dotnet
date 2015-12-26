﻿// --------------------------------------------------------------------------------------------------------------------
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
            if (!ModelState.IsValid)
            {
                return View(company);
            }

            this.cs.CreateCompany(company);

            return View(company);
        }

        [HttpGet]
        public ActionResult Setup(int id)
        {
            // fetch the company 
            var company = this.cs.GetCompanyById(id);
            var busses = this.cs.GetBusses(id);
            var routes = this.cs.GetListOfRoutes(id);

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
            if (!ModelState.IsValid)
            {
                foreach (var k in this.ModelState.Keys.Where(k => !this.ModelState.IsValidField(k)))
                {
                    badFields.Append(k);
                    badFields.Append(" ");
                }

                return this.SendRequestResult(string.Format("Please correct the errors in {0} and submit again", badFields.ToString()), RequestResultType.Warning);
            }

            try
            {
                //this.cs.EditCompany(company);
                return this.SendRequestResult("Data saved", RequestResultType.Success);
            }
            catch (Exception ex)
            {
                return this.SendRequestResult(string.Format("Error updating information: {0}", ex.Message), RequestResultType.Failed);

            }

        }

        [HttpPost]
        public ActionResult UpdateBusses(int id, Bus bus)
        {

            return this.SendRequestResult("Data saved", RequestResultType.Success);
        }

        [HttpPost]
        public ActionResult Payment(int id, Company company)
        {

            return this.SendRequestResult("Data saved", RequestResultType.Success);
        }

        [HttpPost]
        public ActionResult ProcessRoutes()
        {
            return this.SendRequestResult("Data saved", RequestResultType.Success);
        }

        [HttpGet]
        public ActionResult Routes(int id)
        {
            var routes = this.cs.GetListOfRoutes(id).Where(r => r.Id == id);
            return base.ToJson(routes);
        }

        [HttpPost]
        public ActionResult DeleteRoute(int id)
        {
            // do the route deletion here 


            // return a fresh view with available routes. 
            return this.GetRoutesForCompany(id);
        }


        [HttpGet]
        public ActionResult GetRoutesForCompany(int id)
        {
            var routes = this.cs.GetListOfRoutes(id);

            return this.PartialView("_RouteTable", routes);
        }

        [HttpGet]
        public ActionResult GetBussesForCompany(int id)
        {
            var busses = this.cs.GetBusses(id);

            return this.PartialView("_BussesTab", busses);
        }


    }
}