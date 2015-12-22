

namespace Ticket.UI.Web
{

    using Microsoft.Practices.Unity;
    using System.Web.Mvc;
    using Ticket.Business;
    using Ticket.Data;
    using Ticket.Interfaces.Business;
    using Ticket.Interfaces.Data;

    using Unity.Mvc5;


    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<ICompanyService, CompanyService>();
            container.RegisterType<ITripScheduleService, TripScheduleService>();
            container.RegisterType<IScheduleRepository, ScheduleRepository>();
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}