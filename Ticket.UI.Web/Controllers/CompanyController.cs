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
    using System.Web.Mvc;
    using Ticket.Domain;
    using Ticket.Interfaces.Business;

    /// <summary>
    /// The company controller.
    /// </summary>
    public class CompanyController : Controller
    {
        private readonly ICompanyService cs;

        public CompanyController(ICompanyService cs)
        {
            this.cs = cs;
        }

        // GET: Company

        // GET: Company/Create
        #region Public Methods and Operators

        /// <summary>
        /// The create.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
        /// <summary>
        /// The create.
        /// </summary>
        /// <param name="collection">
        /// The collection.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        [HttpPost]
        public ActionResult Create(Company company)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    return RedirectToAction("Index");
                }
                else
                {
                    // Insertion logic 

                    cs.CreateCompany(company);
                    
                    return RedirectToAction("Index"); 
                }
            }
            catch
            {
                return View();
            }
        }
        
        /// <summary>
        /// The details.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Details(int id)
        {
            var company = cs.GetCompanyById(id); 
            
            return View(company);
        }

        /// <summary>
        /// The edit.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Edit(int id)
        {
            var company = cs.GetCompanyById(id); 

            return View(company);
        }

        // POST: Company/Edit/5
        /// <summary>
        /// The edit.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="collection">
        /// The collection.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Index()
        {
            return View();
        }

        #endregion
    }
}