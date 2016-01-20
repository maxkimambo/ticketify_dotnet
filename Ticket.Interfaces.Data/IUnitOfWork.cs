using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Interfaces.Data
{
    using Ticket.Domain;

    public interface IUnitOfWork
    {
        /// <summary>
        ///     Company repository Getter
        /// </summary>
        ICompanyRepository CompanyRepository { get; }

        IScheduleRepository ScheduleRepository { get; }

        IBusRepository BusRepository { get;}


        /// <summary>
        ///     Saves all the changes that happened in a transaction
        /// </summary>
        void Commit();

        /// <summary>
        /// The dispose.
        /// </summary>
        /// <param name="disposing">
        /// The disposing.
        /// </param>
        void Dispose(bool disposing);

        /// <summary>
        /// The dispose.
        /// </summary>
        void Dispose();
    }

}
