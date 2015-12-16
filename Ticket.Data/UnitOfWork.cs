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
    /// The unit of work.
    /// </summary>
    public class UnitOfWork : IDisposable
    {
        #region Fields

        /// <summary>
        /// The context.
        /// </summary>
        private readonly TicketContext context;

        /// <summary>
        /// The company repository.
        /// </summary>
        private Repository<Company> companyRepository;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        public UnitOfWork()
        {
            context = new TicketContext();
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
                    companyRepository = new Repository<Company>(context);
                }

                return companyRepository;
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

        #endregion

        /// <summary>
        /// Finalizes an instance of the <see cref="UnitOfWork"/> class. 
        /// </summary>
        ~UnitOfWork()
        {
            Dispose(false);
        }

        private bool disposed = false; 

        public void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            this.disposed = true; 
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}