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
        // here we will return fake data for now. 
        public override IEnumerable<Schedule> Get(Expression<Func<Schedule, bool>> filter = null, Func<IQueryable<Schedule>, IOrderedQueryable<Schedule>> orderBy = null)
        {
            return new List<Schedule>();
        }
    }
}
