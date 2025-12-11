using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Onion.Application.MappingProfiles;

namespace Onion.Application.DependencyResolvers
{
    public static class DTOMapperResolver
    {
        public static void AddDTOMapperService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DTOMappingProfile));
        }
    }
}
