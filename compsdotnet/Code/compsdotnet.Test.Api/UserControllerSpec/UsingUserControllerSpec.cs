using NSubstitute;
using compsdotnet.Test.Framework;
using compsdotnet.Api.Controllers;
using compsdotnet.BusinessServices.Interfaces;
using AutoMapper;
using compsdotnet.BusinessEntities.Entities;
using compsdotnet.Contracts.DTO;


namespace compsdotnet.Test.Api.UserControllerSpec
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
