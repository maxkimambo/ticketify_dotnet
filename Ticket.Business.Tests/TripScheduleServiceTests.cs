
namespace Ticket.Business.Tests
{
    using FluentAssertions;
    using System.Collections.Generic;
    using Ticket.Domain;
    using Ticket.Interfaces.Business;

    using Xunit;

    public class TripScheduleServiceTests
    {
        private ITripScheduleService sut;

        private List<Schedule> _scheduleTestData;

        [Fact]
        public void ShouldRetrieveAListOfSchedules()
        {
            var schedule = sut.GetFullSchedule();

            schedule.Should().HaveCount(10);
        }

    }
}
