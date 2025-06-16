using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace mycompany_project;

[DependsOn(
    typeof(mycompany_projectDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(mycompany_projectApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
[DependsOn(typeof(AbpAccountAdminApplicationModule))]
    [DependsOn(typeof(AbpAccountPublicApplicationModule))]
    [DependsOn(typeof(AbpAccountSharedApplicationModule))]
    public class mycompany_projectApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<mycompany_projectApplicationModule>();
        });
    }
}
