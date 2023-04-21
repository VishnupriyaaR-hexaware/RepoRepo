using compsdotnet.BusinessEntities.Entities;
using compsdotnet.Contracts.DTO;
using AutoMapper;
namespace compsdotnet.Api.Middleware
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
