using System.Threading.Tasks;
using CED.Localization;
using CED.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace CED.Web.Menus;

public class CEDMenuContributor : IMenuContributor
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
		var administration = context.Menu.GetAdministration();
		var l = context.GetLocalizer<CEDResource>();

		context.Menu.Items.Insert(
			0,
			new ApplicationMenuItem(
				CEDMenus.Home,
				l["Menu:Home"],
				"~/",
				icon: "fas fa-home",
				order: 0
			)
		);

		context.Menu.Items.Insert(
			1,
			new ApplicationMenuItem(
				CEDMenus.ClassInformation,				
				l["ClassInformations"],
				icon: "bi bi-activity"
			).AddItem(
				new ApplicationMenuItem(
				CEDMenus.Classes,
				l["Classes"],
				url: "/ClassInformations",
				icon: "bi bi-journal-text"

				)
		)
		);
        context.Menu.Items.Insert(
            2,
            new ApplicationMenuItem(
                CEDMenus.Subjects,
                l["Subjects"],
                icon: "bi bi-book",
                url: "/Subjects"

            )
        
        );

        if (MultiTenancyConsts.IsEnabled)
		{
			administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
			//administration.SetSubItemOrder()
		}
		else
		{
			administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
		}

		administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
		administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
	}
}
