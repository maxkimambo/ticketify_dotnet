namespace Ticket.Domain
{
    public class Route
    {
        public string Id { get; set; }
        public Location Start { get; set; }
        public Location Destination { get; set; }


        public System.Collections.Generic.List<RouteStop> RouteStops { get; set; }
    }
}