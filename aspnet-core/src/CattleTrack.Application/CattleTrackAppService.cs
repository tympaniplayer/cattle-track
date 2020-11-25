using System;
using System.Collections.Generic;
using System.Text;
using CattleTrack.Localization;
using Volo.Abp.Application.Services;

namespace CattleTrack
{
    /* Inherit your application services from this class.
     */
    public abstract class CattleTrackAppService : ApplicationService
    {
        protected CattleTrackAppService()
        {
            LocalizationResource = typeof(CattleTrackResource);
        }
    }
}
