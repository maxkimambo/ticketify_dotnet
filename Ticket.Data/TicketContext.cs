

using System.Data.Entity.Migrations;
using Ticket.Domain;

namespace Ticket.Data
{
    using System.Data.Entity;

    /// <summary>
    /// The ticket context.
    /// </summary>
    public class TicketContext : DbContext
    {
        public TicketContext()
            : base("name=dev")
        {

        }
        /// <summary>
        /// Gets or sets the companies.
        /// </summary>
        public DbSet<Company> Companies { get; set; }
        public DbSet<Bus> Busses { get; set; }
        public DbSet<Route> Routes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Bus>()
            //    .HasOptional<Company>(c => c.Company)
            //    .WithMany(b => b.Busses); 
               
            base.OnModelCreating(modelBuilder);
        }
    }
}
