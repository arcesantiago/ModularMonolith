using AutoMapper;
using ModularMonolith.Modules.Examples.Core.DTOs;
using ModularMonolith.Modules.Examples.Core.Entities;

namespace ModularMonolith.Modules.Examples.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<CreateExampleDto, Example>()
                .ConstructUsing(src => new Example(src.Id));
        }
    }
}
