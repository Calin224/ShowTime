using System;
using STime.Data;
using STime.Entities;
using STime.Interfaces;

namespace STime.Repos;

public class RepositoryBand(DataContext context) : GenericRepository<Band>(context), IRepositoryBand
{
}
