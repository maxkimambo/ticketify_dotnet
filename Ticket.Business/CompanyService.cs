using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Business
{
    using System.Collections;
    using Ticket.Domain;
    using Ticket.Interfaces.Business;
    using Ticket.Interfaces.Data;

    public class CompanyService : ICompanyService
    {
        private readonly IRepository<Company> companyRepository;

        private readonly IRepository<Bus> busRepo;

        public CompanyService(IRepository<Company> companyRepository, IRepository<Bus> busRepo )
       {
           this.companyRepository = companyRepository;
           this.busRepo = busRepo;
       }


        public IEnumerable<Company> GetCompanies()
        {
            var companies = companyRepository.Get().ToList();
            return companies; 
        }

        public Company GetCompanyById(int id)
        {
           var company = companyRepository.GetById(id);
            return company; 
        }

       public void CreateCompany(Company company)
       {
           companyRepository.Insert(company);
       }

       public void EditCompany(Company company)
       {
           companyRepository.Update(company);
       }

       public void DeleteCompany(int id)
       {
          companyRepository.Delete(id);
       }

       public void DeleteCompany(Company company)
       {
           companyRepository.Delete(company);
       }

       public void AddBus(Company company, Bus bus)
       {
            bus.Company = company; 
            busRepo.Insert(bus);    
       }

        public void RemoveBus(Company company, Bus bus)
        {
            throw new NotImplementedException();
        }
    }
}
