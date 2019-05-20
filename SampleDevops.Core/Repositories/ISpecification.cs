using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SampleDevops.Core.Entities;

namespace SampleDevops.Core.Repositories
{
    public interface ISpecification<TEntity> where TEntity : BaseEntity
    {
        Expression<Func<TEntity, bool>> Criteria { get; }
        Expression<Func<TEntity, object>> OrderBy { get; }
        Expression<Func<TEntity, object>> OrderByDescending { get; }
        List<Expression<Func<TEntity, object>>> Includes { get; }
        List<string> IncludeStrings { get; }
    }
}

