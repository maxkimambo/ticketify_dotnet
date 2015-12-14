namespace Ticket.Domain
{
    using System.Collections.Generic;

    public class Trip
    {
        public string Id;
        public Bus Bus { get; set; }
        public List<Passenger> Passengers { get; set; }
        public Route Route { get; set; }
    }
}