using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlasticosFortuna.Data.Helpers
{
    public static class HttpContextExtensions
    {
        public static async Task InsertPaginationParameterInResponse<T>(this HttpContext httpContext,
            IQueryable<T> queryable, int recordsPerPage )
        {
            double count = await queryable.CountAsync();
            double pagesCount = Math.Ceiling(count / recordsPerPage);
            httpContext.Response.Headers.Add("pagesCount", pagesCount.ToString());
        }
    }
}
