using DotnetSixApp.BusinessEntities.Entities;
using DotnetSixApp.Contracts.DTO;
using AutoMapper;
namespace DotnetSixApp.Api.Middleware
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
