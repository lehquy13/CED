using CED.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace CED.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CEDEntityFrameworkCoreModule),
    typeof(CEDApplicationContractsModule)
    )]
public class CEDDbMigratorModule : AbpModule
{

}
