using System;
using System.Collections.Generic;
using System.Linq;

namespace Ticket.Business
{
    using Ticket.Domain;
    using Ticket.Interfaces.Business;
    using Ticket.Interfaces.Data;

    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<Company> companyRepository;

        private readonly IRepository<Bus> busRepo;

        public CompanyService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.companyRepository = this.unitOfWork.CompanyRepository;
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

        public IEnumerable<Route> GetListOfRoutes(int companyId)
        {
            var routes = new List<Route>();
            var dar = new Location() { Id = 1, Name = "Dar es salaam" };
            var mbeya = new Location() { Id = 2, Name = "Mbeya" };
            var arusha = new Location() { Id = 3, Name = "Arusha" };
            var moshi = new Location() { Id = 3, Name = "Moshi" };
            var nairobi = new Location() { Id = 3, Name = "Nairobi" };

            routes.Add(new Route()
                           {
                               Id = 1,
                               Start = dar,
                               Destination = arusha
                           });

            routes.Add(new Route()
                           {
                               Id = 2,
                               Start = dar,
                               Destination = moshi
                           });

            routes.Add(new Route()
            {
                Id = 2,
                Start = dar,
                Destination = mbeya
            });

            routes.Add(new Route()
            {
                Id = 3,
                Start = moshi,
                Destination = arusha
            });

            routes.Add(new Route()
            {
                Id = 4,
                Start = arusha,
                Destination = mbeya
            });


            return routes;
        }

        public IEnumerable<Bus> GetBusses(int companyId)
        {
            var busses = new List<Bus>();

            // for now just dummy data. 
            busses.Add(new Bus()
                           {
                               Id = 1,
                               Number = "T234 ABG",
                               Capacity = 60
                           });

            busses.Add(new Bus()
            {
                Id = 1,
                Number = "T444 ABG",
                Capacity = 40
            });
            busses.Add(new Bus()
            {
                Id = 1,
                Number = "T333 GHF",
                Capacity = 65
            });
            busses.Add(new Bus()
            {
                Id = 1,
                Number = "T333 BNQ",
                Capacity = 60
            });

            return busses.AsEnumerable();
        }
    }
}
