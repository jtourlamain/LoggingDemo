using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingDemo.Logic;
using Microsoft.Practices.Unity;

namespace LoggingDemo.Host
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();
            Program.Container = container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<ICalculator, Calculator>("DefaultCalculator");
            container.RegisterType<ICalculator, TracingCalculator>(new InjectionConstructor(new ResolvedParameter<ICalculator>("DefaultCalculator")));
        }
    }
}
