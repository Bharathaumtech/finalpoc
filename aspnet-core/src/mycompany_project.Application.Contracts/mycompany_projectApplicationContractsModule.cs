using Volo.Abp.Account;

using Volo.Abp.FeatureManagement;

using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace mycompany_project;

[DependsOn(
    typeof(mycompany_projectDomainSharedModule),
    typeof(AbpAccountApplicationContractsModule),
    typeof(AbpAccountAdminApplicationContractsModule),
    typeof(AbpAccountPublicApplicationContractsModule),
    typeof(AbpAccountSharedApplicationContractsModule),
    typeof(AbpFeatureManagementApplicationContractsModule),

    typeof(AbpPermissionManagementApplicationContractsModule),
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(AbpTenantManagementApplicationContractsModule),
    typeof(AbpObjectExtendingModule)
)]
public class mycompany_projectApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        mycompany_projectDtoExtensions.Configure();
    }
}
