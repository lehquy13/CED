using Volo.Abp.Modularity;

namespace CED;

[DependsOn(
    typeof(CEDApplicationModule),
    typeof(CEDDomainTestModule)
    )]
public class CEDApplicationTestModule : AbpModule
{

}
