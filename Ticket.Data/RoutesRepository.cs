namespace Ticket.Data
{
    using Ticket.Domain;
    using Ticket.Interfaces.Data;

    public class RoutesRepository : Repository<Route>, IRouteRepository
    {
        public RoutesRepository(TicketContext context)
            : base(context)
        {
        }
    }
}