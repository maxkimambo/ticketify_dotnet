using System;
using System.Collections.Generic;

namespace Ticket.Business
{
    using Ticket.Data;
    using Ticket.Domain;
    using Ticket.Interfaces.Business;
    using Ticket.Interfaces.Data;

    public class TripScheduleService : ITripScheduleService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IRepository<Schedule> scheduleRepository;

        public TripScheduleService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Schedule> GetFullSchedule()
        {

            throw new NotImplementedException();
        }

        public IEnumerable<Schedule> GetTodaysSchedule()
        {
            throw new NotImplementedException();
        }

        public void AddItemToSchedule(Schedule schedule)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromSchedule(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Schedule> GetScheduleForRoute(Route route)
        {
            throw new NotImplementedException();
        }
    }
}
