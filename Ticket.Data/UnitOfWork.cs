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

    /// <summary>
    ///     The unit of work.
    /// </summary>
    public class UnitOfWork : IDisposable
    {
        #region Fields

        /// <summary>
        ///     The context.
        /// </summary>
        private readonly TicketContext context;

        /// <summary>
        ///     The company repository.
        /// </summary>
        private Repository<Company> companyRepository;

        /// <summary>
        /// The disposed.
        /// </summary>
        private bool disposed;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="UnitOfWork" /> class.
        /// </summary>
        public UnitOfWork()
        {
            context = new TicketContext("dev");
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

        /// <summary>
        ///     Company repository Getter
        /// </summary>
        public Repository<Company> CompanyRepository
        {
            get
            {
                if (companyRepository == null)
                {
                    companyRepository = new Repository<Company>();
                }

                return companyRepository;
            }
        }

        private IScheduleRepository scheduleRepository;

        public IScheduleRepository ScheduleRepository
        {
            get
            {
                if (this.scheduleRepository == null)
                {
                    this.scheduleRepository = new ScheduleRepository();
                }
                return this.scheduleRepository;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Saves all the changes that happened in a transaction
        /// </summary>
        public void Commit()
        {
            context.SaveChanges();
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