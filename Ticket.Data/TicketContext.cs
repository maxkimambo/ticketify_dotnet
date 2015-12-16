

namespace Ticket.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Ticket.Data.Model;

    /// <summary>
    /// The ticket context.
    /// </summary>
    public class TicketContext : DbContext
    {
        /// <summary>
        /// Gets or sets the companies.
        /// </summary>
        public DbSet<Company> Companies { get; set; }
    }
}
