using AutoMapper;
using CoreBase.Automapper;
using CoreToDo.DTOs;
using CoreToDo.Entities;

namespace CoreToDo.Automapper
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Item, ItemDTO>();
            CreateMap<ItemDTO, Item>()
                .ForMember(dest => dest.ItemState, opt => opt.MapFrom<EntityResolver<ItemStateDTO, ItemState>, ItemStateDTO>(src => src.ItemState));

            CreateMap<ItemState, ItemStateDTO>();

            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, ItemCategory>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom<EntityResolver<CategoryDTO, Category>, CategoryDTO>(src => src));

            CreateMap<ItemCategory, CategoryDTO>()
                .ConvertUsing((src, dest, ctx) =>
                {
                    return ctx.Mapper.Map<Category, CategoryDTO>(src.Category);
                });

            CreateMap<Person, PersonDTO>();
            CreateMap<PersonDTO, Person>();

        }
    }
}
