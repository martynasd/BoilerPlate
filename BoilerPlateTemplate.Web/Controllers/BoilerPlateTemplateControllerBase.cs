using Abp.Web.Mvc.Controllers;

namespace BoilerPlateTemplate.Web.Controllers
{
    public abstract class BoilerPlateTemplateControllerBase : AbpController
    {
        protected BoilerPlateTemplateControllerBase()
        {
            LocalizationSourceName = "BoilerPlateTemplate";
        }
    }
}