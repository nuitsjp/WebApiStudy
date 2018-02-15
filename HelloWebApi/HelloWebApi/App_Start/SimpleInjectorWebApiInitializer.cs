using HelloWebApi.Controllers;

[assembly: WebActivator.PostApplicationStartMethod(typeof(HelloWebApi.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace HelloWebApi.App_Start
{
    using System;
    using System.Linq.Expressions;
    using System.Web.Http;
    using Castle.DynamicProxy;
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
            container.InterceptWith<ControllerInterceptor>(type => type.Name.EndsWith("Controller"));
            container.Register<IEmployeeRepository, EmployeeRepository>(Lifestyle.Scoped);
        }

        private static readonly ProxyGenerator Generator = new ProxyGenerator();

        private static readonly Func<Type, object, IInterceptor, object> CreateProxy =
            (p, t, i) => Generator.CreateClassProxyWithTarget(p, t, i);

        public static void InterceptWith<TInterceptor>(this Container c,
            Predicate<Type> predicate)
            where TInterceptor : class, IInterceptor
        {
            c.ExpressionBuilt += (s, e) =>
            {
                if (predicate(e.RegisteredServiceType))
                {
                    var interceptorExpression =
                        c.GetRegistration(typeof(TInterceptor), true).BuildExpression();

                    e.Expression = Expression.Convert(
                        Expression.Invoke(Expression.Constant(CreateProxy),
                            Expression.Constant(e.RegisteredServiceType, typeof(Type)),
                            e.Expression,
                            interceptorExpression),
                        e.RegisteredServiceType);
                }
            };
        }

    }
}