namespace Ticket.Domain
{

    public class Bus
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int Capacity { get; set; }
        public Company Company { get; set; }
    }
}