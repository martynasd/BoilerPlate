using System;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using Abp.Dependency;
using Abp.Localization;
using Abp.Modules;
using Abp.Startup;
using BoilerPlateTemplate.Web.Localization.BoilerPlateTemplate;

namespace BoilerPlateTemplate.Web
{
    public class BoilerPlateTemplateWebModule : AbpModule
    {
        public override Type[] GetDependedModules()
        {
            return new[]
                   {
                       typeof(BoilerPlateTemplateDataModule),
                       typeof(BoilerPlateTemplateApplicationModule),
                       typeof(BoilerPlateTemplateWebApiModule)
                   };
        }

        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            LocalizationHelper.RegisterSource<BoilerPlateTemplateLocalizationSource>();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
