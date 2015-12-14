namespace Ticket.Domain
{
    using System;

    public class Schedule
    {
        public string Id { get; set; }
        public Bus Bus { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public decimal Fare { get; set; }
        public Route Route { get; set; }
    }
}