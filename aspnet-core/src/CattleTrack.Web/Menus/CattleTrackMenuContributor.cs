﻿using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using CattleTrack.Localization;
using CattleTrack.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace CattleTrack.Web.Menus
{
  public class CattleTrackMenuContributor : IMenuContributor
  {
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
      if (context.Menu.Name == StandardMenus.Main)
      {
        await ConfigureMainMenuAsync(context);
      }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
      var l = context.GetLocalizer<CattleTrackResource>();
      context.Menu.Items.Insert(0, new ApplicationMenuItem(CattleTrackMenus.Home, l["Menu:Home"], "~/"));
    }
  }
}
