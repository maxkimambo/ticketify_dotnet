using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Interfaces.Business
{
    using Ticket.Domain;

    public interface ICompanyService
    {
        IEnumerable<Company> GetCompanies();
        Company GetCompanyById(int id); 
    }
}
