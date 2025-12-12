using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Onion.Application.IUseCases.Attributes;
using Onion.Application.IUseCases.AttributeValues;
using Onion.Application.IUseCases.Entities;
using Onion.Application.UseCases.Attributes;
using Onion.Application.UseCases.Entities;

namespace Onion.Application.DependencyResolvers
{
    public static class UseCaseResolver
    {
        public static void AddUseCaseServices(this IServiceCollection services)
        {
            services.AddScoped<IGetEntityByIdUseCase, GetEntityByIdUseCase>();
            services.AddScoped<IGetEntitiesUseCase, GetEntitiesUseCase>();
            services.AddScoped<ICreateEntityUseCase, CreateEntityUseCase>();

            services.AddScoped<ICreateAttributeUseCase, CreateAttributeUseCase>();
            services.AddScoped<IGetAttributesByEntityIdUseCase, GetAttributesByEntityIdUseCase>();
            services.AddScoped<IGetAttributesUseCase, GetAttributesUseCase>();
        }
    }
}
