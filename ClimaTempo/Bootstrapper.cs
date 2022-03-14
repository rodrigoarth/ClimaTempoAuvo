using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using ClimaTempo.Repository;
using ClimaTempo.Controllers;



namespace ClimaTempo
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        public static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IClimaTempo, ClimaTempoRepository>();
            container.RegisterType<IController, HomeController>();
            return container;
        }
    }
}