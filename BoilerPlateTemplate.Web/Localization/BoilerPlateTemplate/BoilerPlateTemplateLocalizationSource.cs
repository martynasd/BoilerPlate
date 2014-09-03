using System.Web;
using Abp.Localization.Sources.Xml;

namespace BoilerPlateTemplate.Web.Localization.BoilerPlateTemplate
{
    public class BoilerPlateTemplateLocalizationSource : XmlLocalizationSource
    {
        public BoilerPlateTemplateLocalizationSource()
            : base("BoilerPlateTemplate", HttpContext.Current.Server.MapPath("/Localization/BoilerPlateTemplate"))
        {
        }
    }
}