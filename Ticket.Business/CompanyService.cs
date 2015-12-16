using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Business
{
    using System.Collections;
    using Ticket.Domain;
    using Ticket.Interfaces.Business;

   public class CompanyService : ICompanyService
    {
        public IEnumerable<Company> GetCompanies()
        {
            throw new NotImplementedException();
        }

        public Company GetCompanyById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
