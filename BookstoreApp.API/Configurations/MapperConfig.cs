using AutoMapper;
using BookstoreApp.API.Data;
using BookstoreApp.API.Models.Author;

namespace BookstoreApp.API.Configurations
{ 
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();

        }
    }
}
