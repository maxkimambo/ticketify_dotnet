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

            if (company == null)
            {
                ModelState.AddModelError("notfound", "Company not found");
            }

            return View(company); 
        }

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