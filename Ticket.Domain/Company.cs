// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Company.cs" company="">
// </copyright>
// <summary>
//   The company.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Ticket.Domain
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage = "Contact Person is a required field")]
        public string ContactPerson { get; set; }

        /// <summary>
        /// Gets or sets the fax.
        /// </summary>

        public string Fax { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        [Required(ErrorMessage = "Please enter the phone number, it is where we shall transfer your money to..")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the tin.
        /// </summary>
        public string Tin { get; set; }

        #endregion
    }
}