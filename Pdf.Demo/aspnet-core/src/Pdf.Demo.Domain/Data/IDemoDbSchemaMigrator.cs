using System.Threading.Tasks;

namespace Pdf.Demo.Data
{
    public interface IDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
