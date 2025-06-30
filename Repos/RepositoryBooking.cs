using System;
using STime.Data;
using STime.Entities;
using STime.Interfaces;

namespace STime.Repos;

public class RepositoryBooking(DataContext context) : GenericRepository<Booking>(context), IRepositoryBooking
{
}
