using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Interfaces.Data
{
    using Ticket.Domain;

    /// <summary>
    /// The CompanyRepository interface.
    /// </summary>
    public interface ICompanyRepository : IRepository<Company>
    {
    }
}
