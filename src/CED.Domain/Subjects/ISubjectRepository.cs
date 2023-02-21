using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CED.Subjects
{
    public interface ISubjectRepository
    {
        Task<Subject> FindByNameAsync(string name);

        Task<List<Subject>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string filter = null
        );
    }
}
