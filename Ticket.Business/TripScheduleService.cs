using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Business
{
    using Ticket.Domain;

    public class TripScheduleService
    {
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
