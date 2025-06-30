using System;
using STime.Data;
using STime.Entities;
using STime.Interfaces;

namespace STime.Repos;

public class RepositoryFestival(DataContext context) : GenericRepository<Festival>(context), IRepositoryFestival
{
}
