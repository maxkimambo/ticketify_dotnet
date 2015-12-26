using System.Collections.Generic;

namespace Ticket.UI.Web.ViewModels
{
    using Ticket.Domain;

    public class CompanySetupViewModel
    {
        public Company Company { get; set; }
        public IEnumerable<Bus> Busses { get; set; }
        public IEnumerable<Route> Routes { get; set; }
    }
}