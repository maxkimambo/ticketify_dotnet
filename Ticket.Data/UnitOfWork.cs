// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitOfWork.cs" company="">
//   
// </copyright>
// <summary>
//   The unit of work.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Ticket.Data
{
    using System;
    using Ticket.Domain;
    using Ticket.Interfaces.Data;


    /// <summary>
    ///     The unit of work.
    /// </summary>
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        #region Fields

        /// <summary>
        ///     The context.
        /// </summary>
        private readonly TicketContext context;

        /// <summary>
        ///     The company repository.
        /// </summary>
        private ICompanyRepository companyRepository;

        private IScheduleRepository scheduleRepository; 


        /// <summary>
        /// The disposed.
        /// </summary>
        private bool disposed;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <param name="companyRepository">
        /// The company Repository.
        /// </param>
        /// <param name="scheduleRepository">
        /// The schedule Repository.
        /// </param>
        public UnitOfWork()
        {
            context = new TicketContext();
        }

        /// <summary>
        ///     Finalizes an instance of the <see cref="UnitOfWork" /> class.
        /// </summary>
        ~UnitOfWork()
        {
            Dispose(false);
        }

        #endregion

        #region Public Properties

        #endregion

        #region Public Methods and Operators

        public ICompanyRepository CompanyRepository
        {
            get
            {
                if (companyRepository == null)
                {
                    companyRepository = new CompanyRepository(context); 
                }
                return companyRepository; 
            }
        }

        public IScheduleRepository ScheduleRepository
        {
            get { return scheduleRepository ?? (scheduleRepository = new ScheduleRepository(context)); }
        }

        /// <summary>
        ///     Saves all the changes that happened in a transaction
        /// </summary>
        public void Commit()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// The dispose.
        /// </summary>
        /// <param name="disposing">
        /// The disposing.
        /// </param>
        public void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            disposed = true;
        }

        /// <summary>
        /// The dispose.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}