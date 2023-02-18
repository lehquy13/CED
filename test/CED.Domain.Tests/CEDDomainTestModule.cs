using CED.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CED;

[DependsOn(
    typeof(CEDEntityFrameworkCoreTestModule)
    )]
public class CEDDomainTestModule : AbpModule
{

}
