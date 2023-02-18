using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CED.Data;

/* This is used if database provider does't define
 * ICEDDbSchemaMigrator implementation.
 */
public class NullCEDDbSchemaMigrator : ICEDDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
