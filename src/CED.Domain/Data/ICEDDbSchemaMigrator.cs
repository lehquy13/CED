using System.Threading.Tasks;

namespace CED.Data;

public interface ICEDDbSchemaMigrator
{
    Task MigrateAsync();
}
