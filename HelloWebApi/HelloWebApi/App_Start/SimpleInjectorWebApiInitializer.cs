[assembly: WebActivator.PostApplicationStartMethod(typeof(HelloWebApi.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace HelloWebApi.App_Start
{
    using System.Web.Http;
    using HelloWebApi.Models;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    using SimpleInjector.Lifestyles;

    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            
            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
       
            container.Verify();
            
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
     
        private static void InitializeContainer(Container container)
        {
            container.Register<IEmployeeRepository, EmployeeRepository>(Lifestyle.Scoped);
        }
    }
}