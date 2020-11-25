using CattleTrack.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CattleTrack.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class CattleTrackPageModel : AbpPageModel
    {
        protected CattleTrackPageModel()
        {
            LocalizationResourceType = typeof(CattleTrackResource);
        }
    }
}