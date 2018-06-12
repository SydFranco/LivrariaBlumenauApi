using LivrariaBlumenau.Application.Interface;
using LivrariaBlumenau.Application.Service;
using LivrariaBlumenau.Domain.Interfaces.Repositories;
using LivrariaBlumenau.Domain.Interfaces.Services;
using LivrariaBlumenau.Domain.Services;
using LivrariaBlumenau.Infrastructure.Data.Repositories;
using LivrariaBlumenau.App.WebApi;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using Ninject.Web.WebApi;
using System;
using System.Web;
using System.Web.Http;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(NinjectWebCommon), "Stop")]


namespace LivrariaBlumenau.App.WebApi
{
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            Bootstrapper.Initialize(CreateKernel);
        }
        public static void Stop()
        {
            Bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            RegisterServices(kernel);
            GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);
            return kernel;
        }
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppService<>)).To(typeof(AppService<>));
            kernel.Bind<ILivroAppService>().To<LivroAppService>();

            kernel.Bind(typeof(IService<>)).To(typeof(ServiceBase<>));
            kernel.Bind<ILivroService>().To<LivroService>();

            kernel.Bind(typeof(IRepository<>)).To(typeof(Repository<>));
            kernel.Bind<ILivroRepository>().To<LivroRepository>();
        }
    }
}
