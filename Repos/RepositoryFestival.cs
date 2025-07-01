using System;
using Microsoft.EntityFrameworkCore;
using STime.Data;
using STime.Entities;
using STime.Interfaces;

namespace STime.Repos;

public class RepositoryFestival(DataContext context) : GenericRepository<Festival>(context), IRepositoryFestival
{
    public async Task<IReadOnlyList<Festival>> IncludeBands()
    {
        return await context.Festivals
            .Include(f => f.Bands)
            .ToListAsync();
    }
}
