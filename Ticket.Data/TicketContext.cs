

using System.Data.Entity.Migrations;
using Ticket.Domain;

namespace Ticket.Data
{
    using System.Data.Entity;
    using Ticket.Data.Model;

    /// <summary>
    /// The ticket context.
    /// </summary>
    public class TicketContext : DbContext
    {
        public TicketContext()
            : base("dev")
        {

        }
        /// <summary>
        /// Gets or sets the companies.
        /// </summary>
        public DbSet<Company> Companies { get; set; }
        public DbSet<Bus> Busses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Bus>()
            //    .HasOptional<Company>(c => c.Company)
            //    .WithMany(b => b.Busses); 
               
            base.OnModelCreating(modelBuilder);
        }
    }
}
