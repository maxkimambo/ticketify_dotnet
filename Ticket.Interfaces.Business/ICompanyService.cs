using System.Collections.Generic;

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

        void RemoveBus(int id);

        IEnumerable<Route> GetListOfRoutes(int companyId);

        IEnumerable<Bus> GetBusses(int companyId);

        void UpdateBus(Bus bus); 
    }
}
