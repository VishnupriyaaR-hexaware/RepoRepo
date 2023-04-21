using NSubstitute;
using finalcomp.Test.Framework;
using finalcomp.Api.Controllers;
using finalcomp.BusinessServices.Interfaces;
using AutoMapper;
using finalcomp.BusinessEntities.Entities;
using finalcomp.Contracts.DTO;


namespace finalcomp.Test.Api.UserControllerSpec
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
