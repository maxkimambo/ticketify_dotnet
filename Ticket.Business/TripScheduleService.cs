// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TripScheduleService.cs" company="">
//   
// </copyright>
// <summary>
//   The trip schedule service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Ticket.Business
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Ticket.Domain;
    using Ticket.Interfaces.Business;
    using Ticket.Interfaces.Data;

    /// <summary>
    /// The trip schedule service.
    /// </summary>
    public class TripScheduleService : ITripScheduleService
    {
        #region Fields

        /// <summary>
        /// The schedule repository.
        /// </summary>
        private readonly IRepository<Schedule> scheduleRepository;

        /// <summary>
        /// The unit of work.
        /// </summary>
        private readonly IUnitOfWork unitOfWork;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TripScheduleService"/> class.
        /// </summary>
        /// <param name="unitOfWork">
        /// The unit of work.
        /// </param>
        public TripScheduleService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The add item to schedule.
        /// </summary>
        /// <param name="schedule">
        /// The schedule.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public void AddItemToSchedule(Schedule schedule)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The get full schedule.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public IEnumerable<Schedule> GetFullSchedule()
        {
            var fullSchedule = this.unitOfWork.ScheduleRepository.Get();

            return fullSchedule.ToList(); 
        }

        /// <summary>
        /// The get schedule for route.
        /// </summary>
        /// <param name="route">
        /// The route.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public IEnumerable<Schedule> GetScheduleForRoute(Route route)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The get todays schedule.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public IEnumerable<Schedule> GetFeaturedDestinationsSchedule()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The remove from schedule.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public void RemoveFromSchedule(int id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}