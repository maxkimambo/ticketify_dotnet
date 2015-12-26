namespace Ticket.Domain
{

    public class Bus
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int Capacity { get; set; }
        //public string Type { get; set; }
        //public Location Destination { get; set; }
        //public List<Service> Services { get; set; }
        public Company Company { get; set; }
    }
}