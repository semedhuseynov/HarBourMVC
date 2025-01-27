﻿using System;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Repository.Helpers.Extensions
{
    public static class QueryExtension
    {
        public static IQueryable<T> IncludeMultiple<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] includes) where T : class
        {
            if (includes is not null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }

            return query;
        }
    }
}

