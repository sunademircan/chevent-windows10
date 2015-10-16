using System.Collections.Generic;
using System.Reflection;
using Autofac;
using System.Reflection;
using chevent.Windows10.Business.Services.Service;
using chevent.Windows10.Data.Repository.Repository;

namespace chevent.Windows10.App
{
    public static class ViewModelLocator
    {

        public static void Initialize()
        {
            var container = new ContainerBuilder();
            //var build = RegisterServices(container);
           
        }

        //private static IContainer RegisterServices(ContainerBuilder builder)
        //{
        //    var assemblies = new List<Assembly>
        //    {
        //        Assembly.  Load(typeof(EventBusinessLogic)),
        //        Assembly.Load(typeof(EventRepository)),
        //    },
        //    foreach (var assebly in assemblies)
        //    {
        //        builder.RegisterAssemblyTypes(assebly)
        //            .Where(
        //                t =>
        //                    t.Name.EndsWith("Repository") || t.Name.EndsWith("BusinessLogic"))
        //                    .AsImplementedInterfaces();


        //    }
        //}


        //private static IEventBusinessLogic eventBusinessLogic = new EventBusinessLogic(new EventRepository());

        //private static EventOverviewViewModel = new EventOverviewViewModel(eventBusinessLogic)

    }
}
