using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Data
{
    using System.Linq.Expressions;
    using Ticket.Domain;
    using Ticket.Interfaces.Data;

    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private List<Company> seedData;

        public CompanyRepository()
        {
            GenerateSeed(); 
        }

        private void GenerateSeed()
        {
          
            this.seedData = new List<Company>();
            this.seedData.Add(new Company()
            {
                Id = 1,
                Address = "Address 1",
                ContactPerson = "Mike traveller",
                Name = "Mike Safaris",
                Phone = "1232132",
                Fax = "4444",
                Tin = "5555"
            });
            this.seedData.Add(new Company()
            {
                Id = 2,
                Address = "Address 2",
                ContactPerson = "Owner",
                Name = "Kilimanjaro",
                Phone = "444423",
                Fax = "4444",
                Tin = "5555"
            });

            this.seedData.Add(new Company()
            {
                Id = 3,
                Address = "Address 3",
                ContactPerson = "Mr. Owen",
                Name = "Simba safari",
                Phone = "12343452",
                Fax = "4444",
                Tin = "5555"
            });
        }


        /// <summary>
        /// The get by id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="Company"/>.
        /// </returns>
        public override Company GetById(int id)
        {
            var company = this.seedData.FirstOrDefault(c => (int) c.Id == id);
            
            return company; 
        }

        public override void Insert(Company entity)
        {
            this.seedData.Add(entity);
        }

        public override IEnumerable<Company> Get(
            Expression<Func<Company, bool>> filter = null,
            Func<IQueryable<Company>, IOrderedQueryable<Company>> orderBy = null)
        {
            var query = this.seedData.AsQueryable(); 

            // if something was given to filter by then apply it here
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }

            return this.seedData; 
        }


    }
}
