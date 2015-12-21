

namespace Ticket.Data
{
    using System.Data.Entity;
    using Ticket.Data.Model;

    /// <summary>
    /// The ticket context.
    /// </summary>
    public class TicketContext : DbContext
    {
        public TicketContext(string connString)
            : base(connString)
        {

        }
        /// <summary>
        /// Gets or sets the companies.
        /// </summary>
        public DbSet<CompanyDo> Companies { get; set; }
    }
}
