using System;
using System.Collections.Generic;
using System.Linq;

namespace Ticket.Data
{
    using System.Linq.Expressions;

    using Ticket.Domain;

    public class ScheduleRepository : Repository<Schedule>, IScheduleRepository
    {

        public override IEnumerable<Schedule> Get(Expression<Func<Schedule, bool>> filter = null, Func<IQueryable<Schedule>, IOrderedQueryable<Schedule>> orderBy = null)
        {
            return new List<Schedule>();
        }
    }
}
