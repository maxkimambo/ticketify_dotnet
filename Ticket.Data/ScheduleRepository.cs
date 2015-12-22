using System;
using System.Collections.Generic;
using System.Linq;

namespace Ticket.Data
{
    using System.Linq.Expressions;

    using Ticket.Domain;
    using Ticket.Interfaces.Data;

    public class ScheduleRepository : Repository<Schedule>, IScheduleRepository
    {

        private List<Schedule> scheduleTable;  

        // here we will return fake data for now. 
        public override IEnumerable<Schedule> Get(Expression<Func<Schedule, bool>> filter = null, Func<IQueryable<Schedule>, IOrderedQueryable<Schedule>> orderBy = null)
        {
            scheduleTable = new List<Schedule>();
          
            scheduleTable.Add(new Schedule()
            {
                Departure = new DateTime(2015,12,25,6,30,00),
                Arrival = new DateTime(2015, 12, 25, 6, 30, 00).AddHours(12),
                Bus = new Bus() { Capacity = 65 }
            });
            return scheduleTable;
        }
    }
}
