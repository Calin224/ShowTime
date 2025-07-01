using System;
using STime.Entities;

namespace STime.Interfaces;

public interface IRepositoryFestival : IGenericRepository<Festival>
{
    Task<IReadOnlyList<Festival>> IncludeBands();
}
