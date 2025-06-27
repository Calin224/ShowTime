using System;
using System.Linq.Expressions;
using Humanizer;
using STime.Entities;

namespace STime.Interfaces;

public interface ISpecification<T>
{
    Expression<Func<T, bool>>? Criteria { get; }
    Expression<Func<T, object>>? OrderBy { get; }
    Expression<Func<T, object>>? OrderByDesc { get; }
}
