using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Onion.Application.DTOs.Attributes;
using Onion.Application.DTOs.Entities;
using Onion.Application.DTOs.Values;
using Onion.Domain.Models;

namespace Onion.Application.MappingProfiles
{
    public class DTOMappingProfile : Profile
    {
        public DTOMappingProfile()
        {
            CreateMap<Entity, EntityResultDTO>().ReverseMap();
            CreateMap<EntityAttribute, AttributeResultDTO>().ReverseMap();
            CreateMap<AttributeValue, ValueResultDTO>().ReverseMap();
        }
    }
}
