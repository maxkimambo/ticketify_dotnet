namespace Ticket.Domain
{
    using System.Collections.Generic;

    public class Route
    {
        public int Id { get; set; }
        public Company Company { get; set; }
        public Location Start { get; set; }
        public Location Destination { get; set; }
        public List<Bus> AssignedBusses { get; set; }
    }
}