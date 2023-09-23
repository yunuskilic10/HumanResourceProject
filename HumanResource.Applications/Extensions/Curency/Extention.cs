using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Extensions.Curency
{
    public static class Extention
    {
        public static async  Task<IApplicationBuilder> UseCurrency(this IApplicationBuilder app)
        {
    
            return app.UseMiddleware<CurencyData>();
        }
    }
}
