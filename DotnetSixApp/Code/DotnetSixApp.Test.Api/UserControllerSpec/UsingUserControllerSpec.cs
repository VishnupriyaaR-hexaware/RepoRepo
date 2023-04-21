using NSubstitute;
using DotnetSixApp.Test.Framework;
using DotnetSixApp.Api.Controllers;
using DotnetSixApp.BusinessServices.Interfaces;
using AutoMapper;
using DotnetSixApp.BusinessEntities.Entities;
using DotnetSixApp.Contracts.DTO;


namespace DotnetSixApp.Test.Api.UserControllerSpec
{
    public abstract class UsingUserControllerSpec : SpecFor<UserController>
    {
        protected IUserService _userService;
        protected IMapper _mapper;

        public override void Context()
        {
            _userService = Substitute.For<IUserService>();
            _mapper = Substitute.For<IMapper>();
            subject = new UserController(_userService,_mapper);

        }

    }
}
