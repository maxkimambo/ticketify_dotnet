using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Interfaces.Business
{
    using Ticket.Domain;

    public interface ICompanyService
    {
        IEnumerable<Company> GetCompanies();
        Company GetCompanyById(int id);
        
        void CreateCompany(Company company);

        void EditCompany(Company company);

        void DeleteCompany(int id);

        void DeleteCompany(Company company);

        void AddBus(Company company, Bus bus);

        void RemoveBus(Company company, Bus bus); 
    }
}
