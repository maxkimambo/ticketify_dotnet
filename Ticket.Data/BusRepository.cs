using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Data
{
    using Ticket.Domain;
    using Ticket.Interfaces.Data;

    public class BusRepository : Repository<Bus>, IBusRepository
    {
        public BusRepository(TicketContext context)
            : base(context)
        {
        }
    }
}
