namespace Ticket.Interfaces.Business
{
    using System.Collections.Generic;

    using Ticket.Domain;

    public interface ITripScheduleService
    {
        IEnumerable<Schedule> GetFullSchedule();

        IEnumerable<Schedule> GetFeaturedDestinationsSchedule();

        void AddItemToSchedule(Schedule schedule);

        void RemoveFromSchedule(int id);

        IEnumerable<Schedule> GetScheduleForRoute(Route route);
    }
}