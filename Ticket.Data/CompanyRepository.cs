using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Data
{
    using Ticket.Domain;
    using Ticket.Interfaces.Data;

    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
    }
}
