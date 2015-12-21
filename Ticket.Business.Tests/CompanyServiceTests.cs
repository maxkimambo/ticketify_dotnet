using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Business.Tests
{
    using FluentAssertions;
    using Moq;
    using Ticket.Domain;
    using Ticket.Interfaces.Business;
    using Ticket.Interfaces.Data;
    using Xunit;
    
    public class CompanyServiceTests
    {
        private IRepository<Company> companyRepo = new Mock<IRepository<Company>>().Object;

        private ICompanyService sut;

        private List<Company> companyList;  

        public CompanyServiceTests()
        {
            
            InitializeSeedData();
        }


        private void InitializeSeedData()
        {
            companyList = new List<Company>()
            {
                new Company()
                {
                    Id = 1, ContactPerson = "Test person", Address = "Some address", Fax = "121212", Phone = "076323432", Name = "Company 1", Tin = "2222"
                },
                new Company()
                {
                    Id = 2, ContactPerson = "Test person", Address = "Some address", Fax = "121212", Phone = "076323432", Name = "Company 2", Tin = "2222"
                },
                new Company()
                {
                    Id = 3, ContactPerson = "Test person", Address = "Some address", Fax = "121212", Phone = "076323432", Name = "Company 3", Tin = "2222"
                },
                new Company()
                {
                    Id = 4, ContactPerson = "Test person", Address = "Some address", Fax = "121212", Phone = "076323432", Name = "Company 4", Tin = "2222"
                }
            };
        }

        [Fact]
        public void ShouldRetrieveAListOfCompanies()
        {
            var companyRepo = new Mock<IRepository<Company>>();
            companyRepo.Setup(s => s.Get(null, null))
                .Returns(companyList);
            var busRepo = new Mock<IRepository<Bus>>().Object;  
            sut = new CompanyService(companyRepo.Object, busRepo);
            var result = sut.GetCompanies();
            result.Count().Should().Be(4); 
        }
    }
}
