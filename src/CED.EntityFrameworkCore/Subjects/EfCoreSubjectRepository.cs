using CED.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace CED.Subjects
{
    // not using right now

    internal class EfCoreSubjectRepository : EfCoreRepository<CEDDbContext, Subject, Guid>,
        ISubjectRepository
    {
        public EfCoreSubjectRepository(
        IDbContextProvider<CEDDbContext> dbContextProvider)
        : base(dbContextProvider)
        {
        }

        public async Task<Subject> FindByNameAsync(string name)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.FirstOrDefaultAsync(subject => subject.Name == name);
        }

        public async Task<List<Subject>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string filter = null)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet
                .WhereIf(
                    !filter.IsNullOrWhiteSpace(),
                    subject => subject.Name.Contains(filter)
                    )
                .OrderBy(sorting)
                .Skip(skipCount)
                .Take(maxResultCount)
                .ToListAsync();
        }
    }
}
