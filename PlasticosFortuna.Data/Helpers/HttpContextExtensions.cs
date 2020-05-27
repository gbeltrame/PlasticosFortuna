using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace PlasticosFortuna.Data.Helpers
{
    public static class HttpContextExtensions
    {
        public static async Task InsertarParametrosPaginacionEnRespuesta<T>(this HttpContext context,
               IQueryable<T> queryable, int itemCountToDisplay)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            double count = await queryable.CountAsync();
            double totalPageCount = Math.Ceiling(count / itemCountToDisplay);
            context.Response.Headers.Add("totalPageCount", totalPageCount.ToString());

        }
    }
}
