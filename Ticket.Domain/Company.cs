// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Company.cs" company="">
// </copyright>
// <summary>
//   The company.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket.Domain
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    ///     The company.
    /// </summary>
    public class Company
    {
        #region Public Properties

        public Company()
        {
            Busses = new List<Bus>();
        }

        /// <summary>
        ///     Gets or sets the address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        ///     Gets or sets the busses.
        /// </summary>
        public virtual ICollection<Bus> Busses { get; set; }

        /// <summary>
        ///     Gets or sets the contact person.
        /// </summary>
        public string ContactPerson { get; set; }

        /// <summary>
        ///     Gets or sets the fax.
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
       
        //public int Id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }
        //[Required(ErrorMessage = "Please enter a number registered with mobile banking")]
        public string MobileBankingNumber { get; set; }

        public MobileProviderType MobileProvider { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the phone.
        /// </summary>
        [Required(ErrorMessage = "Please enter the phone number, it is where we shall transfer your money to..")]
        public string Phone { get; set; }

        /// <summary>
        ///     Gets or sets the tin.
        /// </summary>
        public string Tin { get; set; }

        #endregion
    }

    public enum MobileProviderType
    {
        Tigo,

        Zain,

        Vodacom
    }
}