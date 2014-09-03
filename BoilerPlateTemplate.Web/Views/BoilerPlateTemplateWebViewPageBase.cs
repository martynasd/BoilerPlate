using Abp.Web.Mvc.Views;

namespace BoilerPlateTemplate.Web.Views
{
    public abstract class BoilerPlateTemplateWebViewPageBase : BoilerPlateTemplateWebViewPageBase<dynamic>
    {

    }

    public abstract class BoilerPlateTemplateWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected BoilerPlateTemplateWebViewPageBase()
        {
            LocalizationSourceName = "BoilerPlateTemplate";
        }
    }
}