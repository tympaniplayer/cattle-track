using CattleTrack.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CattleTrack.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CattleTrackController : AbpController
    {
        protected CattleTrackController()
        {
            LocalizationResource = typeof(CattleTrackResource);
        }
    }
}