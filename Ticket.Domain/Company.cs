// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Company.cs" company="">
//   
// </copyright>
// <summary>
//   The company.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Ticket.Domain
{
    using System.Collections.Generic;

    /// <summary>
    /// The company.
    /// </summary>
    public class Company
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the busses.
        /// </summary>
        public virtual List<Bus> Busses { get; set; }

        /// <summary>
        /// Gets or sets the contact person.
        /// </summary>
        public string ContactPerson { get; set; }

        /// <summary>
        /// Gets or sets the fax.
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public object Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the tin.
        /// </summary>
        public string Tin { get; set; }

        #endregion
    }
}