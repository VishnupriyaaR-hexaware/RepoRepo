using finalcomp.BusinessEntities.Entities;
using finalcomp.Contracts.DTO;
using AutoMapper;
namespace finalcomp.Api.Middleware
{
public class MappingFile : Profile
{
    public MappingFile()
    {
        // Mapping variables
		CreateMap<User , UserDto>(); 
    }
  }
}
